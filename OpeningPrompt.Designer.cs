﻿using System;

namespace Microsoft.Samples.Kinect.BodyBasics
{
    partial class OpeningPrompt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SessionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.captureSkeletons = new System.Windows.Forms.CheckBox();
            this.captureFaces = new System.Windows.Forms.CheckBox();
            this.captureSound = new System.Windows.Forms.CheckBox();
            this.chooseFolder = new System.Windows.Forms.Button();
            this.savingDataLabel = new System.Windows.Forms.Label();
            this.savingDataPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SessionID
            // 
            this.SessionID.Location = new System.Drawing.Point(29, 45);
            this.SessionID.Name = "SessionID";
            this.SessionID.Size = new System.Drawing.Size(183, 26);
            this.SessionID.TabIndex = 0;
            this.SessionID.Text = "Default";
            this.SessionID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Session Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(29, 349);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 34);
            this.ok.TabIndex = 2;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(175, 349);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(88, 34);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // captureSkeletons
            // 
            this.captureSkeletons.AutoSize = true;
            this.captureSkeletons.Location = new System.Drawing.Point(29, 89);
            this.captureSkeletons.Name = "captureSkeletons";
            this.captureSkeletons.Size = new System.Drawing.Size(167, 24);
            this.captureSkeletons.TabIndex = 4;
            this.captureSkeletons.Text = "Capture Skeletons";
            this.captureSkeletons.ThreeState = true;
            this.captureSkeletons.UseVisualStyleBackColor = true;
            // 
            // captureFaces
            // 
            this.captureFaces.AutoSize = true;
            this.captureFaces.Location = new System.Drawing.Point(29, 120);
            this.captureFaces.Name = "captureFaces";
            this.captureFaces.Size = new System.Drawing.Size(140, 24);
            this.captureFaces.TabIndex = 5;
            this.captureFaces.Text = "Capture Faces";
            this.captureFaces.ThreeState = true;
            this.captureFaces.UseVisualStyleBackColor = true;
            this.captureFaces.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // captureSound
            // 
            this.captureSound.AutoSize = true;
            this.captureSound.Location = new System.Drawing.Point(29, 151);
            this.captureSound.Name = "captureSound";
            this.captureSound.Size = new System.Drawing.Size(143, 24);
            this.captureSound.TabIndex = 6;
            this.captureSound.Text = "Capture Sound";
            this.captureSound.ThreeState = true;
            this.captureSound.UseVisualStyleBackColor = true;
            // 
            // chooseFolder
            // 
            this.chooseFolder.Location = new System.Drawing.Point(29, 262);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(183, 31);
            this.chooseFolder.TabIndex = 7;
            this.chooseFolder.Text = "Choose Folder";
            this.chooseFolder.UseVisualStyleBackColor = true;
            this.chooseFolder.Click += new System.EventHandler(this.chooseFolderClick);
            // 
            // savingDataLabel
            // 
            this.savingDataLabel.AutoSize = true;
            this.savingDataLabel.Location = new System.Drawing.Point(25, 207);
            this.savingDataLabel.Name = "savingDataLabel";
            this.savingDataLabel.Size = new System.Drawing.Size(115, 20);
            this.savingDataLabel.TabIndex = 8;
            this.savingDataLabel.Text = "Saving data to:";
            // 
            // savingDataPath
            // 
            this.savingDataPath.Location = new System.Drawing.Point(29, 230);
            this.savingDataPath.Name = "savingDataPath";
            this.savingDataPath.Size = new System.Drawing.Size(265, 26);
            this.savingDataPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this.savingDataPath.TabIndex = 9;
            // 
            // OpeningPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 395);
            this.Controls.Add(this.savingDataPath);
            this.Controls.Add(this.savingDataLabel);
            this.Controls.Add(this.chooseFolder);
            this.Controls.Add(this.captureSound);
            this.Controls.Add(this.captureFaces);
            this.Controls.Add(this.captureSkeletons);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SessionID);
            this.Name = "OpeningPrompt";
            this.Text = "Kinect Data Collection Tool";
            this.Load += new System.EventHandler(this.OpeningPrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox SessionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        public System.Windows.Forms.CheckBox captureSkeletons;
        public System.Windows.Forms.CheckBox captureFaces;
        public System.Windows.Forms.CheckBox captureSound;
        private System.Windows.Forms.Button chooseFolder;
        private System.Windows.Forms.Label savingDataLabel;
        public System.Windows.Forms.TextBox savingDataPath;
    }
}