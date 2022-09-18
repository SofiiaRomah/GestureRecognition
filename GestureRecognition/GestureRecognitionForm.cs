using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using GestureRecognition.Infrastructure;
using GestureRecognition.Localization;

namespace GestureRecognition
{
    public partial class GesturesRecognitionForm : Form
    {
        private VideoCapture _videoCapture;
        private Rectangle _handGestureArea;
        private bool _saveTrainingImageData;
        public GesturesRecognitionForm()
        {
            InitializeComponent();
            ApplyLocalization();
            SetBinaryImageThresholdTrackBarProperties();

            _videoCapture = new VideoCapture();
            _handGestureArea = new Rectangle(Constants.HAND_GESTURE_AREA_LOCATION_X,
                Constants.HAND_GESTURE_AREA_LOCATION_Y,
                Constants.HAND_GESTURE_AREA_WIDTH,
                Constants.HAND_GESTURE_AREA_HEIGHT);
            _saveTrainingImageData = false;

            SetGestureNumbersComboBoxValues();
            SetTrainingButtonsIsEnabled();
            SetContoursExternalCheckBoxIsChecked();
            SetVideoCaptureSize();
            BindApplicationIdleEvent();
        }
        private void ApplyLocalization()
        {
            this.Text = GestureRecognitionLocalization.HandGesturesRecognitionFormTitleText;
            this.videoCaptureLabel.Text = GestureRecognitionLocalization.VideoCaptureLabelText;
            this.binaryImageLabel.Text = GestureRecognitionLocalization.BinaryImageLabelText;
            this.contoursLabel.Text = GestureRecognitionLocalization.ContoursLabelText;
            this.contourBoundingRectanglesLabel.Text = GestureRecognitionLocalization.ContourBoundingRectanglesLabelText;
            this.biggestContourBoundingRectangleLabel.Text = GestureRecognitionLocalization.BiggestContourBoundingRectangleLabelText;
            this.squaredBiggestContourBoundingRectangleLabel.Text = GestureRecognitionLocalization.SquaredBiggestContourBoundingRectangleLabel;
            this.dataImageLabel.Text = GestureRecognitionLocalization.DataImageLabelText;
            this.optionsGroupBox.Text = GestureRecognitionLocalization.OptionsGroupBoxText;
            this.binaryImageThresholdTrackBarLabel.Text = GestureRecognitionLocalization.BinaryImageThresholdTrackBarLabelText;
            this.areContoursExternalCheckBox.Text = GestureRecognitionLocalization.AreContoursExternalCheckBoxText;
            this.recognitionOptionsGroupBox.Text = GestureRecognitionLocalization.RecognitionOptionsGroupBoxText;
            this.imageToRecognizeLabel.Text = GestureRecognitionLocalization.ImageToRecognizeLabelText;
            this.recognitionResultLabel.Text = GestureRecognitionLocalization.RecognitionResultLabelText;
            this.captureImageToRecognizeButton.Text = GestureRecognitionLocalization.CaptureImageToRecognizeButtonText;
            this.recognizeImageButton.Text = GestureRecognitionLocalization.RecognizeImageButtonText;
            this.trainingOptionsGroupBox.Text = GestureRecognitionLocalization.TrainingOptionsGroupBoxText;
            this.infoLabel.Text = GestureRecognitionLocalization.InfoLabelText;
            this.gestureNumberLabel.Text = GestureRecognitionLocalization.GestureNumberLabelText;
            this.stopTrainingButton.Text = GestureRecognitionLocalization.StopTrainingButtonText;
            this.startTrainingButton.Text = GestureRecognitionLocalization.StartTrainingButtonText;
        }
        private void SetBinaryImageThresholdTrackBarProperties()
        {
            binaryImageThresholdTrackBar.Minimum = Constants.MIN_COLOR_VALUE;
            binaryImageThresholdTrackBar.Maximum = Constants.MAX_COLOR_VALUE;
            binaryImageThresholdTrackBar.Value = Constants.DEFAULT_THRESHOLD_VALUE;
        }

        private void SetGestureNumbersComboBoxValues()
        {
            for (int i = 0; i < 10; i++)
            {
                gestureNumberComboBox.Items.Add(i);
            }
        }

        private void SetTrainingButtonsIsEnabled()
        {
            startTrainingButton.Enabled = !_saveTrainingImageData;
            stopTrainingButton.Enabled = _saveTrainingImageData;
        }
        private void SetContoursExternalCheckBoxIsChecked()
        {
            areContoursExternalCheckBox.Checked = true;
        }

        private void SetVideoCaptureSize()
        {
            _videoCapture.Set(CapProp.FrameWidth, videoCapturePictureBox.Width);
            _videoCapture.Set(CapProp.FrameHeight, videoCapturePictureBox.Height);
        }

        private void BindApplicationIdleEvent()
        {
            Application.Idle += delegate
            {
                var videoCaptureImageMatrix = _videoCapture.QueryFrame();
                DrawVideoCaptureImage(videoCaptureImageMatrix);

                using (var grayImage = videoCaptureImageMatrix.ToImage<Gray, byte>())
                {
                    grayImage.ROI = _handGestureArea;
                }
            };
        }
        private void DrawVideoCaptureImage(Mat videoCaptureImageMatrix)
        {
            CvInvoke.Rectangle(videoCaptureImageMatrix, _handGestureArea, new MCvScalar(0, 0, 255));
            videoCapturePictureBox.Image = videoCaptureImageMatrix.ToBitmap();
        }
    }
}
