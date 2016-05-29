﻿//------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.BodyBasics
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Media.Media3D;
    using Microsoft.Kinect;
    using Microsoft.Kinect.Face;

    /// <summary>
    /// Interaction logic for MainWindow
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        /// <summary>
        /// Active Kinect sensor
        /// </summary>
        private KinectSensor kinectSensor = null;

        /// <summary>
        /// Bitmap to display
        /// </summary>
        private Logger logger;

        /// <summary>
        /// Bitmap to display
        /// </summary>
        private DrawingColorImage drawingColorImage;

        /// <summary>
        /// Bitmap to display
        /// </summary>
        private DrawingBodies drawingBodies;

        /// <summary>
        /// Current status text to display
        /// </summary>
        private string statusText = null;

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            // get session ID
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Session ID", "Kinect Data Collection Tool", "Default", -1, -1);
            if (input == "") Application.Current.Shutdown();
            this.logger = new Logger(input);

            // one sensor is currently supported
            this.kinectSensor = KinectSensor.GetDefault();

            // create an object to manage the color frames
            this.drawingColorImage = new DrawingColorImage(this.kinectSensor);

            // create an object to manage the skeletons
            this.drawingBodies = new DrawingBodies(this.kinectSensor, this.logger);

            // set IsAvailableChanged event notifier
            this.kinectSensor.IsAvailableChanged += this.Sensor_IsAvailableChanged;

            // open the sensor
            this.kinectSensor.Open();

            // set the status text
            this.StatusText = this.kinectSensor.IsAvailable ? Properties.Resources.RunningStatusText
                                                            : Properties.Resources.NoSensorStatusText;

            // use the window object as the view model in this simple example
            this.DataContext = this;

            // initialize the components (controls) of the window
            this.InitializeComponent();
        }

        /// <summary>
        /// INotifyPropertyChangedPropertyChanged event to allow window controls to bind to changeable data
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the bitmap to display
        /// </summary>
        public ImageSource ImageSource
        {
            get
            {
                return this.drawingBodies.imageSource;
            }
        }

        /// <summary>
        /// Gets the bitmap to display
        /// </summary>
        public ImageSource ColorImageSource
        {
            get
            {
                return this.drawingColorImage.colorBitmap;
            }
        }

        /// <summary>
        /// Gets or sets the current status text to display
        /// </summary>
        public string StatusText
        {
            get
            {
                return this.statusText;
            }

            set
            {
                if (this.statusText != value)
                {
                    this.statusText = value;

                    // notify any bound elements that the text has changed
                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("StatusText"));
                    }
                }
            }
        }


        /// <summary>
        /// Execute start up tasks
        /// </summary>
        /// <param name="sender">object sending the event</param>
        /// <param name="e">event arguments</param>
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < this.drawingBodies.bodyCount; i++)
            {
                if (this.drawingBodies.faceFrameReaders[i] != null)
                {
                    // wire handler for face frame arrival
                    this.drawingBodies.faceFrameReaders[i].FrameArrived += this.drawingBodies.Reader_FaceFrameArrived;
                }
            }

            if (this.drawingBodies.bodyFrameReader != null)
            {
                // wire handler for body frame arrival
                this.drawingBodies.bodyFrameReader.FrameArrived += this.drawingBodies.Reader_FrameArrived;
                //this.bodyFrameReader.FrameArrived += this.Reader_BodyFrameArrived;
            }
        }

        /// <summary>
        /// Execute shutdown tasks
        /// </summary>
        /// <param name="sender">object sending the event</param>
        /// <param name="e">event arguments</param>
        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            if (this.drawingColorImage.colorFrameReader != null)
            {
                // ColorFrameReder is IDisposable
                this.drawingColorImage.colorFrameReader.Dispose();
                this.drawingColorImage.colorFrameReader = null;
            }

            for (int i = 0; i < this.drawingBodies.bodyCount; i++)
            {
                if (this.drawingBodies.faceFrameReaders[i] != null)
                {
                    // FaceFrameReader is IDisposable
                    this.drawingBodies.faceFrameReaders[i].Dispose();
                    this.drawingBodies.faceFrameReaders[i] = null;
                }

                if (this.drawingBodies.faceFrameSources[i] != null)
                {
                    // FaceFrameSource is IDisposable
                    this.drawingBodies.faceFrameSources[i].Dispose();
                    this.drawingBodies.faceFrameSources[i] = null;
                }
            }

            if (this.drawingBodies.bodyFrameReader != null)
            {
                // BodyFrameReader is IDisposable
                this.drawingBodies.bodyFrameReader.Dispose();
                this.drawingBodies.bodyFrameReader = null;
            }

            if (this.kinectSensor != null)
            {
                this.kinectSensor.Close();
                this.kinectSensor = null;
            }
        }
        
        /// <summary>
        /// Handles the event which the sensor becomes unavailable (E.g. paused, closed, unplugged).
        /// </summary>
        /// <param name="sender">object sending the event</param>
        /// <param name="e">event arguments</param>
        private void Sensor_IsAvailableChanged(object sender, IsAvailableChangedEventArgs e)
        {
            // on failure, set the status text
            this.StatusText = this.kinectSensor.IsAvailable ? Properties.Resources.RunningStatusText
                                                            : Properties.Resources.SensorNotAvailableStatusText;
        }


        // controls
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Handle(sender as CheckBox);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Handle(sender as CheckBox);
        }

        void Handle(CheckBox checkBox)
        {
            // Use IsChecked.
            bool flag = checkBox.IsChecked.Value;
            if (checkBox.Name.ToString() == "body")
                logger.log_body = flag;
            if (checkBox.Name.ToString() == "face")
                logger.log_face = flag;
        }
    }
}