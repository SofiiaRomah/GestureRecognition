
namespace GestureRecognition
{
    partial class GesturesRecognitionForm
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
            this.videoCaptureLabel = new System.Windows.Forms.Label();
            this.videoCapturePictureBox = new System.Windows.Forms.PictureBox();
            this.binaryImagePictureBox = new System.Windows.Forms.PictureBox();
            this.binaryImageLabel = new System.Windows.Forms.Label();
            this.contoursPictureBox = new System.Windows.Forms.PictureBox();
            this.contourBoundingRectanglesPictureBox = new System.Windows.Forms.PictureBox();
            this.contoursLabel = new System.Windows.Forms.Label();
            this.contourBoundingRectanglesLabel = new System.Windows.Forms.Label();
            this.biggestContourBoundingRectangleLabel = new System.Windows.Forms.Label();
            this.squaredBiggestContourBoundingRectangleLabel = new System.Windows.Forms.Label();
            this.dataImageLabel = new System.Windows.Forms.Label();
            this.biggestContourBoundingRectanglePictureBox = new System.Windows.Forms.PictureBox();
            this.squaredBiggestContourBoundingRectanglePictureBox = new System.Windows.Forms.PictureBox();
            this.dataImagePictureBox = new System.Windows.Forms.PictureBox();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.areContoursExternalCheckBox = new System.Windows.Forms.CheckBox();
            this.binaryImageThresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.binaryImageThresholdTrackBarLabel = new System.Windows.Forms.Label();
            this.recognitionOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.recognizeImageButton = new System.Windows.Forms.Button();
            this.captureImageToRecognizeButton = new System.Windows.Forms.Button();
            this.recognitionResultTextBox = new System.Windows.Forms.TextBox();
            this.recognitionResultLabel = new System.Windows.Forms.Label();
            this.imageToRecognizePictureBox = new System.Windows.Forms.PictureBox();
            this.imageToRecognizeLabel = new System.Windows.Forms.Label();
            this.trainingOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.startTrainingButton = new System.Windows.Forms.Button();
            this.stopTrainingButton = new System.Windows.Forms.Button();
            this.gestureNumberComboBox = new System.Windows.Forms.ComboBox();
            this.gestureNumberLabel = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.videoCapturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contoursPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contourBoundingRectanglesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biggestContourBoundingRectanglePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squaredBiggestContourBoundingRectanglePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataImagePictureBox)).BeginInit();
            this.optionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binaryImageThresholdTrackBar)).BeginInit();
            this.recognitionOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageToRecognizePictureBox)).BeginInit();
            this.trainingOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoCaptureLabel
            // 
            this.videoCaptureLabel.AutoSize = true;
            this.videoCaptureLabel.Location = new System.Drawing.Point(12, 9);
            this.videoCaptureLabel.Name = "videoCaptureLabel";
            this.videoCaptureLabel.Size = new System.Drawing.Size(46, 17);
            this.videoCaptureLabel.TabIndex = 0;
            this.videoCaptureLabel.Text = "label1";
            // 
            // videoCapturePictureBox
            // 
            this.videoCapturePictureBox.Location = new System.Drawing.Point(15, 38);
            this.videoCapturePictureBox.Name = "videoCapturePictureBox";
            this.videoCapturePictureBox.Size = new System.Drawing.Size(800, 591);
            this.videoCapturePictureBox.TabIndex = 1;
            this.videoCapturePictureBox.TabStop = false;
            this.videoCapturePictureBox.Click += new System.EventHandler(this.videoCapturePictureBox_Click);
            // 
            // binaryImagePictureBox
            // 
            this.binaryImagePictureBox.Location = new System.Drawing.Point(831, 38);
            this.binaryImagePictureBox.Name = "binaryImagePictureBox";
            this.binaryImagePictureBox.Size = new System.Drawing.Size(246, 227);
            this.binaryImagePictureBox.TabIndex = 2;
            this.binaryImagePictureBox.TabStop = false;
            // 
            // binaryImageLabel
            // 
            this.binaryImageLabel.AutoSize = true;
            this.binaryImageLabel.Location = new System.Drawing.Point(831, 9);
            this.binaryImageLabel.Name = "binaryImageLabel";
            this.binaryImageLabel.Size = new System.Drawing.Size(46, 17);
            this.binaryImageLabel.TabIndex = 3;
            this.binaryImageLabel.Text = "label2";
            // 
            // contoursPictureBox
            // 
            this.contoursPictureBox.Location = new System.Drawing.Point(1100, 38);
            this.contoursPictureBox.Name = "contoursPictureBox";
            this.contoursPictureBox.Size = new System.Drawing.Size(246, 227);
            this.contoursPictureBox.TabIndex = 4;
            this.contoursPictureBox.TabStop = false;
            // 
            // contourBoundingRectanglesPictureBox
            // 
            this.contourBoundingRectanglesPictureBox.Location = new System.Drawing.Point(1368, 38);
            this.contourBoundingRectanglesPictureBox.Name = "contourBoundingRectanglesPictureBox";
            this.contourBoundingRectanglesPictureBox.Size = new System.Drawing.Size(246, 227);
            this.contourBoundingRectanglesPictureBox.TabIndex = 5;
            this.contourBoundingRectanglesPictureBox.TabStop = false;
            // 
            // contoursLabel
            // 
            this.contoursLabel.AutoSize = true;
            this.contoursLabel.Location = new System.Drawing.Point(1100, 9);
            this.contoursLabel.Name = "contoursLabel";
            this.contoursLabel.Size = new System.Drawing.Size(46, 17);
            this.contoursLabel.TabIndex = 6;
            this.contoursLabel.Text = "label3";
            // 
            // contourBoundingRectanglesLabel
            // 
            this.contourBoundingRectanglesLabel.AutoSize = true;
            this.contourBoundingRectanglesLabel.Location = new System.Drawing.Point(1365, 9);
            this.contourBoundingRectanglesLabel.Name = "contourBoundingRectanglesLabel";
            this.contourBoundingRectanglesLabel.Size = new System.Drawing.Size(46, 17);
            this.contourBoundingRectanglesLabel.TabIndex = 7;
            this.contourBoundingRectanglesLabel.Text = "label4";
            // 
            // biggestContourBoundingRectangleLabel
            // 
            this.biggestContourBoundingRectangleLabel.AutoSize = true;
            this.biggestContourBoundingRectangleLabel.Location = new System.Drawing.Point(831, 295);
            this.biggestContourBoundingRectangleLabel.Name = "biggestContourBoundingRectangleLabel";
            this.biggestContourBoundingRectangleLabel.Size = new System.Drawing.Size(46, 17);
            this.biggestContourBoundingRectangleLabel.TabIndex = 8;
            this.biggestContourBoundingRectangleLabel.Text = "label5";
            // 
            // squaredBiggestContourBoundingRectangleLabel
            // 
            this.squaredBiggestContourBoundingRectangleLabel.AutoSize = true;
            this.squaredBiggestContourBoundingRectangleLabel.Location = new System.Drawing.Point(1100, 295);
            this.squaredBiggestContourBoundingRectangleLabel.Name = "squaredBiggestContourBoundingRectangleLabel";
            this.squaredBiggestContourBoundingRectangleLabel.Size = new System.Drawing.Size(46, 17);
            this.squaredBiggestContourBoundingRectangleLabel.TabIndex = 9;
            this.squaredBiggestContourBoundingRectangleLabel.Text = "label6";
            // 
            // dataImageLabel
            // 
            this.dataImageLabel.AutoSize = true;
            this.dataImageLabel.Location = new System.Drawing.Point(1365, 295);
            this.dataImageLabel.Name = "dataImageLabel";
            this.dataImageLabel.Size = new System.Drawing.Size(46, 17);
            this.dataImageLabel.TabIndex = 10;
            this.dataImageLabel.Text = "label7";
            // 
            // biggestContourBoundingRectanglePictureBox
            // 
            this.biggestContourBoundingRectanglePictureBox.Location = new System.Drawing.Point(831, 315);
            this.biggestContourBoundingRectanglePictureBox.Name = "biggestContourBoundingRectanglePictureBox";
            this.biggestContourBoundingRectanglePictureBox.Size = new System.Drawing.Size(246, 227);
            this.biggestContourBoundingRectanglePictureBox.TabIndex = 11;
            this.biggestContourBoundingRectanglePictureBox.TabStop = false;
            // 
            // squaredBiggestContourBoundingRectanglePictureBox
            // 
            this.squaredBiggestContourBoundingRectanglePictureBox.Location = new System.Drawing.Point(1100, 315);
            this.squaredBiggestContourBoundingRectanglePictureBox.Name = "squaredBiggestContourBoundingRectanglePictureBox";
            this.squaredBiggestContourBoundingRectanglePictureBox.Size = new System.Drawing.Size(246, 227);
            this.squaredBiggestContourBoundingRectanglePictureBox.TabIndex = 12;
            this.squaredBiggestContourBoundingRectanglePictureBox.TabStop = false;
            // 
            // dataImagePictureBox
            // 
            this.dataImagePictureBox.Location = new System.Drawing.Point(1368, 315);
            this.dataImagePictureBox.Name = "dataImagePictureBox";
            this.dataImagePictureBox.Size = new System.Drawing.Size(246, 227);
            this.dataImagePictureBox.TabIndex = 13;
            this.dataImagePictureBox.TabStop = false;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.areContoursExternalCheckBox);
            this.optionsGroupBox.Controls.Add(this.binaryImageThresholdTrackBar);
            this.optionsGroupBox.Controls.Add(this.binaryImageThresholdTrackBarLabel);
            this.optionsGroupBox.Location = new System.Drawing.Point(831, 557);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(787, 101);
            this.optionsGroupBox.TabIndex = 14;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "groupBox1";
            // 
            // areContoursExternalCheckBox
            // 
            this.areContoursExternalCheckBox.AutoSize = true;
            this.areContoursExternalCheckBox.Location = new System.Drawing.Point(602, 17);
            this.areContoursExternalCheckBox.Name = "areContoursExternalCheckBox";
            this.areContoursExternalCheckBox.Size = new System.Drawing.Size(98, 21);
            this.areContoursExternalCheckBox.TabIndex = 2;
            this.areContoursExternalCheckBox.Text = "checkBox1";
            this.areContoursExternalCheckBox.UseVisualStyleBackColor = true;
            // 
            // binaryImageThresholdTrackBar
            // 
            this.binaryImageThresholdTrackBar.Location = new System.Drawing.Point(6, 45);
            this.binaryImageThresholdTrackBar.Name = "binaryImageThresholdTrackBar";
            this.binaryImageThresholdTrackBar.Size = new System.Drawing.Size(772, 56);
            this.binaryImageThresholdTrackBar.TabIndex = 1;
            // 
            // binaryImageThresholdTrackBarLabel
            // 
            this.binaryImageThresholdTrackBarLabel.AutoSize = true;
            this.binaryImageThresholdTrackBarLabel.Location = new System.Drawing.Point(6, 18);
            this.binaryImageThresholdTrackBarLabel.Name = "binaryImageThresholdTrackBarLabel";
            this.binaryImageThresholdTrackBarLabel.Size = new System.Drawing.Size(46, 17);
            this.binaryImageThresholdTrackBarLabel.TabIndex = 0;
            this.binaryImageThresholdTrackBarLabel.Text = "label8";
            // 
            // recognitionOptionsGroupBox
            // 
            this.recognitionOptionsGroupBox.Controls.Add(this.recognizeImageButton);
            this.recognitionOptionsGroupBox.Controls.Add(this.captureImageToRecognizeButton);
            this.recognitionOptionsGroupBox.Controls.Add(this.recognitionResultTextBox);
            this.recognitionOptionsGroupBox.Controls.Add(this.recognitionResultLabel);
            this.recognitionOptionsGroupBox.Controls.Add(this.imageToRecognizePictureBox);
            this.recognitionOptionsGroupBox.Controls.Add(this.imageToRecognizeLabel);
            this.recognitionOptionsGroupBox.Location = new System.Drawing.Point(15, 671);
            this.recognitionOptionsGroupBox.Name = "recognitionOptionsGroupBox";
            this.recognitionOptionsGroupBox.Size = new System.Drawing.Size(800, 332);
            this.recognitionOptionsGroupBox.TabIndex = 15;
            this.recognitionOptionsGroupBox.TabStop = false;
            this.recognitionOptionsGroupBox.Text = "groupBox2";
            // 
            // recognizeImageButton
            // 
            this.recognizeImageButton.Location = new System.Drawing.Point(277, 139);
            this.recognizeImageButton.Name = "recognizeImageButton";
            this.recognizeImageButton.Size = new System.Drawing.Size(250, 30);
            this.recognizeImageButton.TabIndex = 21;
            this.recognizeImageButton.Text = "button2";
            this.recognizeImageButton.UseVisualStyleBackColor = true;
            this.recognizeImageButton.Click += new System.EventHandler(this.recognizeImageButton_Click);
            // 
            // captureImageToRecognizeButton
            // 
            this.captureImageToRecognizeButton.Location = new System.Drawing.Point(277, 91);
            this.captureImageToRecognizeButton.Name = "captureImageToRecognizeButton";
            this.captureImageToRecognizeButton.Size = new System.Drawing.Size(250, 30);
            this.captureImageToRecognizeButton.TabIndex = 20;
            this.captureImageToRecognizeButton.Text = "button1";
            this.captureImageToRecognizeButton.UseVisualStyleBackColor = true;
            this.captureImageToRecognizeButton.Click += new System.EventHandler(this.captureImageToRecognizeButton_Click);
            // 
            // recognitionResultTextBox
            // 
            this.recognitionResultTextBox.Location = new System.Drawing.Point(277, 51);
            this.recognitionResultTextBox.Name = "recognitionResultTextBox";
            this.recognitionResultTextBox.Size = new System.Drawing.Size(250, 22);
            this.recognitionResultTextBox.TabIndex = 19;
            // 
            // recognitionResultLabel
            // 
            this.recognitionResultLabel.AutoSize = true;
            this.recognitionResultLabel.Location = new System.Drawing.Point(274, 31);
            this.recognitionResultLabel.Name = "recognitionResultLabel";
            this.recognitionResultLabel.Size = new System.Drawing.Size(54, 17);
            this.recognitionResultLabel.TabIndex = 18;
            this.recognitionResultLabel.Text = "label10";
            // 
            // imageToRecognizePictureBox
            // 
            this.imageToRecognizePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageToRecognizePictureBox.Location = new System.Drawing.Point(6, 51);
            this.imageToRecognizePictureBox.Name = "imageToRecognizePictureBox";
            this.imageToRecognizePictureBox.Size = new System.Drawing.Size(246, 227);
            this.imageToRecognizePictureBox.TabIndex = 17;
            this.imageToRecognizePictureBox.TabStop = false;
            // 
            // imageToRecognizeLabel
            // 
            this.imageToRecognizeLabel.Location = new System.Drawing.Point(6, 31);
            this.imageToRecognizeLabel.Name = "imageToRecognizeLabel";
            this.imageToRecognizeLabel.Size = new System.Drawing.Size(250, 17);
            this.imageToRecognizeLabel.TabIndex = 0;
            this.imageToRecognizeLabel.Text = "label9";
            // 
            // trainingOptionsGroupBox
            // 
            this.trainingOptionsGroupBox.Controls.Add(this.startTrainingButton);
            this.trainingOptionsGroupBox.Controls.Add(this.stopTrainingButton);
            this.trainingOptionsGroupBox.Controls.Add(this.gestureNumberComboBox);
            this.trainingOptionsGroupBox.Controls.Add(this.gestureNumberLabel);
            this.trainingOptionsGroupBox.Controls.Add(this.infoTextBox);
            this.trainingOptionsGroupBox.Controls.Add(this.infoLabel);
            this.trainingOptionsGroupBox.Location = new System.Drawing.Point(834, 671);
            this.trainingOptionsGroupBox.Name = "trainingOptionsGroupBox";
            this.trainingOptionsGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trainingOptionsGroupBox.Size = new System.Drawing.Size(784, 332);
            this.trainingOptionsGroupBox.TabIndex = 16;
            this.trainingOptionsGroupBox.TabStop = false;
            this.trainingOptionsGroupBox.Text = "groupBox3";
            // 
            // startTrainingButton
            // 
            this.startTrainingButton.Location = new System.Drawing.Point(299, 113);
            this.startTrainingButton.Name = "startTrainingButton";
            this.startTrainingButton.Size = new System.Drawing.Size(100, 24);
            this.startTrainingButton.TabIndex = 5;
            this.startTrainingButton.Text = "button4";
            this.startTrainingButton.UseVisualStyleBackColor = true;
            this.startTrainingButton.Click += new System.EventHandler(this.startTrainingButton_Click);
            // 
            // stopTrainingButton
            // 
            this.stopTrainingButton.Location = new System.Drawing.Point(184, 113);
            this.stopTrainingButton.Name = "stopTrainingButton";
            this.stopTrainingButton.Size = new System.Drawing.Size(100, 24);
            this.stopTrainingButton.TabIndex = 4;
            this.stopTrainingButton.Text = "button3";
            this.stopTrainingButton.UseVisualStyleBackColor = true;
            this.stopTrainingButton.Click += new System.EventHandler(this.stopTrainingButton_Click);
            // 
            // gestureNumberComboBox
            // 
            this.gestureNumberComboBox.FormattingEnabled = true;
            this.gestureNumberComboBox.Location = new System.Drawing.Point(9, 112);
            this.gestureNumberComboBox.Name = "gestureNumberComboBox";
            this.gestureNumberComboBox.Size = new System.Drawing.Size(160, 24);
            this.gestureNumberComboBox.TabIndex = 3;
            // 
            // gestureNumberLabel
            // 
            this.gestureNumberLabel.AutoSize = true;
            this.gestureNumberLabel.Location = new System.Drawing.Point(6, 91);
            this.gestureNumberLabel.Name = "gestureNumberLabel";
            this.gestureNumberLabel.Size = new System.Drawing.Size(54, 17);
            this.gestureNumberLabel.TabIndex = 2;
            this.gestureNumberLabel.Text = "label12";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(9, 51);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(390, 22);
            this.infoTextBox.TabIndex = 1;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(6, 31);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(54, 17);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "label11";
            // 
            // GesturesRecognitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 1055);
            this.Controls.Add(this.trainingOptionsGroupBox);
            this.Controls.Add(this.recognitionOptionsGroupBox);
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.dataImagePictureBox);
            this.Controls.Add(this.squaredBiggestContourBoundingRectanglePictureBox);
            this.Controls.Add(this.biggestContourBoundingRectanglePictureBox);
            this.Controls.Add(this.dataImageLabel);
            this.Controls.Add(this.squaredBiggestContourBoundingRectangleLabel);
            this.Controls.Add(this.biggestContourBoundingRectangleLabel);
            this.Controls.Add(this.contourBoundingRectanglesLabel);
            this.Controls.Add(this.contoursLabel);
            this.Controls.Add(this.contourBoundingRectanglesPictureBox);
            this.Controls.Add(this.contoursPictureBox);
            this.Controls.Add(this.binaryImageLabel);
            this.Controls.Add(this.binaryImagePictureBox);
            this.Controls.Add(this.videoCapturePictureBox);
            this.Controls.Add(this.videoCaptureLabel);
            this.Name = "GesturesRecognitionForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.videoCapturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contoursPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contourBoundingRectanglesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biggestContourBoundingRectanglePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squaredBiggestContourBoundingRectanglePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataImagePictureBox)).EndInit();
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binaryImageThresholdTrackBar)).EndInit();
            this.recognitionOptionsGroupBox.ResumeLayout(false);
            this.recognitionOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageToRecognizePictureBox)).EndInit();
            this.trainingOptionsGroupBox.ResumeLayout(false);
            this.trainingOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label videoCaptureLabel;
        private System.Windows.Forms.PictureBox videoCapturePictureBox;
        private System.Windows.Forms.PictureBox binaryImagePictureBox;
        private System.Windows.Forms.Label binaryImageLabel;
        private System.Windows.Forms.PictureBox contoursPictureBox;
        private System.Windows.Forms.PictureBox contourBoundingRectanglesPictureBox;
        private System.Windows.Forms.Label contoursLabel;
        private System.Windows.Forms.Label contourBoundingRectanglesLabel;
        private System.Windows.Forms.Label biggestContourBoundingRectangleLabel;
        private System.Windows.Forms.Label squaredBiggestContourBoundingRectangleLabel;
        private System.Windows.Forms.Label dataImageLabel;
        private System.Windows.Forms.PictureBox biggestContourBoundingRectanglePictureBox;
        private System.Windows.Forms.PictureBox squaredBiggestContourBoundingRectanglePictureBox;
        private System.Windows.Forms.PictureBox dataImagePictureBox;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.TrackBar binaryImageThresholdTrackBar;
        private System.Windows.Forms.Label binaryImageThresholdTrackBarLabel;
        private System.Windows.Forms.CheckBox areContoursExternalCheckBox;
        private System.Windows.Forms.GroupBox recognitionOptionsGroupBox;
        private System.Windows.Forms.GroupBox trainingOptionsGroupBox;
        private System.Windows.Forms.Button recognizeImageButton;
        private System.Windows.Forms.Button captureImageToRecognizeButton;
        private System.Windows.Forms.TextBox recognitionResultTextBox;
        private System.Windows.Forms.Label recognitionResultLabel;
        private System.Windows.Forms.PictureBox imageToRecognizePictureBox;
        private System.Windows.Forms.Label imageToRecognizeLabel;
        private System.Windows.Forms.ComboBox gestureNumberComboBox;
        private System.Windows.Forms.Label gestureNumberLabel;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button startTrainingButton;
        private System.Windows.Forms.Button stopTrainingButton;
    }
}

