   M S B A M L   `   `   `  ����   BodyBasics-WPF4    .Microsoft.Samples.Kinect.BodyBasics.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  Body Basics��$	��768��$
��1024�� � 	Resources    MediumGreyBrush �� Color  KinectPurpleBrush  KinectBlueBrush��%]   &	        &	      &	 *     �� $ 	#ff6e6e6e���� $ 	#ff52318f���� $ 	#ff00BCF2��.��� $��	10 0 10 0q� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��0��$��Images\Logo.png��$
��Left=�$
��Fill=�$��32��$��81��$��0 10 0 5q��� $��0��$��0,0,-0.667,0.333q�$��Right=�$��Bottom=�#��[  $��Segoe UI)�$��18(�$	��244��$!��Kinect Data Collection Tool���� $��0��$��Images\Status.png��$
��None=�$��Center=�$��124,5,823.6,0.2q�(� $��1��$��Center=�.���� $��UniformToFill=����� *ColorImageSource+(� $��1��$��Center=�.���� $��UniformToFill=����� *ImageSource+(� $��1��$��Center=�.���� -    ��Name$ 
DepthImage��$��UniformToFill=����� *DepthImageSource+ J� Opacity ��  �� ElementName$ depthSlider�� �� Path$ Value��� -   $��	statusBar��$��2��$��Stretch=�$��Bottom=�
�������#��[  .@��� $
��Left=����� *
StatusText+�� -    ��Name$ savingTo��$��Saving to: ��$��Right=��� -   	 ��Name$	 startRecording��$��Start Recording?��$
��Left=�$��
221,11,0,0q�$	��Top=�$	��157��$��35���� -   
 ��Name$
 depthSlider��$
��Left=�$��
423,25,0,0q�$	��Top=�$��20��$	��112�� � Maximum$ 1Q��� -   $ depthImagelabel��$��Show Depth Image��$
��Left=�$��	423,5,0,0q�$	��Top=�