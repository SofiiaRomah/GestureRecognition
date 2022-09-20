using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
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
                    using (var binaryImage = new Image<Gray, byte>(new Size()
                    {
                        Width = Constants.HAND_GESTURE_AREA_WIDTH,
                        Height = Constants.HAND_GESTURE_AREA_HEIGHT
                    }))
                    {
                        ThresholdImage(grayImage, binaryImage);
                        DrawBinaryImage(binaryImage);

                        using (var contoursImage = new Image<Gray, byte>(new Size()
                        {
                            Width = Constants.HAND_GESTURE_AREA_WIDTH,
                            Height = Constants.HAND_GESTURE_AREA_HEIGHT
                        }))
                        {
                            var contours = GetImageContours(binaryImage);
                            DrawContoursImage(contoursImage, contours);

                            var bitmapContoursImage = contoursImage.ToBitmap();

                            using (var contourBoundingRectanglesImage = new Image<Gray, byte>(contoursImage.Data))
                            {
                                DrawContourBoundingRectanglesImage(contours, contourBoundingRectanglesImage);

                                using (var biggestContourBoundingRectangleImage =
                                       new Image<Gray, byte>(contoursImage.Data))
                                {
                                    var biggestContourBoundingRectangle = contours.Size > 0
                                        ? GetBiggestContourBoundingRectangle(contours)
                                        : binaryImage.ROI;

                                    DrawBiggestContourBoundingRectangleImage(biggestContourBoundingRectangleImage,
                                        biggestContourBoundingRectangle);

                                    using (var copyMakeBorderInputImage = new Image<Gray, byte>(contoursImage.Data))
                                    {
                                        using (var squaredBiggestContourBoundingRectangleMat = new Mat())
                                        {
                                            SquareBiggestContourBoundingRectangleImage(biggestContourBoundingRectangle,
                                                copyMakeBorderInputImage, squaredBiggestContourBoundingRectangleMat);

                                            using (var squaredBiggestContourBoundingRectangleImage =
                                                   squaredBiggestContourBoundingRectangleMat.ToImage<Gray, byte>())
                                            {
                                                DrawSquaredBiggestContourBoundingRectangleImage(
                                                    squaredBiggestContourBoundingRectangleImage);

                                                using (var dataImage = squaredBiggestContourBoundingRectangleImage
                                                           .Resize(Constants.OUTPUT_DATA_IMAGE_SIDE_SIZE,
                                                               Constants.OUTPUT_DATA_IMAGE_SIDE_SIZE, Inter.Linear))
                                                {
                                                    if (_saveTrainingImageData)
                                                    {
                                                        //SaveTrainingImageData(dataImage);
                                                    }

                                                    DrawDataImage(dataImage);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
        private void DrawVideoCaptureImage(Mat videoCaptureImageMatrix)
        {
            CvInvoke.Rectangle(videoCaptureImageMatrix, _handGestureArea, new MCvScalar(0, 0, 255));
            videoCapturePictureBox.Image = videoCaptureImageMatrix.ToBitmap();
        }

        private void ThresholdImage(Image<Gray, byte> grayImage, Image<Gray, byte> binaryImage)
        {
            CvInvoke.Threshold(grayImage,
                binaryImage,
                binaryImageThresholdTrackBar.Value,
                Constants.MAX_COLOR_VALUE,
                ThresholdType.Binary);
        }

        private void DrawBinaryImage(Image<Gray, byte> binaryImage)
        {
            binaryImagePictureBox.Image = binaryImage.ToBitmap();
        }

        private VectorOfVectorOfPoint GetImageContours(Image<Gray, byte> binaryImage)
        {
            var contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(binaryImage,
                contours,
                null,
                areContoursExternalCheckBox.Checked ? RetrType.External : RetrType.Ccomp,
                ChainApproxMethod.ChainApproxSimple);
            return contours;
        }

        private void DrawContoursImage(Image<Gray, byte> contoursImage, VectorOfVectorOfPoint contours)
        {
            CvInvoke.DrawContours(contoursImage, contours, -1, new MCvScalar(255, 255, 255), thickness: 2);
            contoursPictureBox.Image = contoursImage.ToBitmap();
        }

        private void DrawContourBoundingRectanglesImage(VectorOfVectorOfPoint contours, Image<Gray, byte> boundingRectanglesImage)
        {
            for (int i = 0; i < contours.Size; i++)
            {
                using (VectorOfPoint contour = contours[i])
                {
                    boundingRectanglesImage.Draw(CvInvoke.BoundingRectangle(contour), new Gray(255));
                }
            }

            contourBoundingRectanglesPictureBox.Image = boundingRectanglesImage.ToBitmap();
        }

        private Rectangle GetBiggestContourBoundingRectangle(VectorOfVectorOfPoint contours)
        {
            var biggestContourBoundingRectangle = CvInvoke.BoundingRectangle(contours[0]);

            for (int i = 0; i < contours.Size; i++)
            {
                using (VectorOfPoint contour = contours[i])
                {
                    var contourBoundingRectangle = CvInvoke.BoundingRectangle(contour);

                    if (biggestContourBoundingRectangle.Width * biggestContourBoundingRectangle.Height < contourBoundingRectangle.Width * contourBoundingRectangle.Height &&
                        contourBoundingRectangle.Width != Constants.HAND_GESTURE_AREA_WIDTH
                        && contourBoundingRectangle.Height != Constants.HAND_GESTURE_AREA_HEIGHT)
                    {
                        biggestContourBoundingRectangle = contourBoundingRectangle;
                    }
                }
            }

            return biggestContourBoundingRectangle;
        }

        private void DrawBiggestContourBoundingRectangleImage(Image<Gray, byte> biggestBoundingRectangleImage, Rectangle biggestBoundingRectangle)
        {
            biggestBoundingRectangleImage.Draw(biggestBoundingRectangle, new Gray(255));
            biggestContourBoundingRectanglePictureBox.Image = biggestBoundingRectangleImage.ToBitmap();
        }

        private static void SquareBiggestContourBoundingRectangleImage(Rectangle boundingRectangle, Image<Gray, byte> copyMakeBorderInputImage, Mat boundingRectangleMat)
        {
            copyMakeBorderInputImage.ROI = boundingRectangle;

            CvInvoke.CopyMakeBorder(copyMakeBorderInputImage,
                boundingRectangleMat,
                boundingRectangle.Width > boundingRectangle.Height ? (boundingRectangle.Width - boundingRectangle.Height) / 2 : 0,
                boundingRectangle.Width > boundingRectangle.Height ? (boundingRectangle.Width - boundingRectangle.Height) / 2 : 0,
                boundingRectangle.Width < boundingRectangle.Height ? (boundingRectangle.Height - boundingRectangle.Width) / 2 : 0,
                boundingRectangle.Width < boundingRectangle.Height ? (boundingRectangle.Height - boundingRectangle.Width) / 2 : 0,
                BorderType.Constant);
        }
        
        private void DrawSquaredBiggestContourBoundingRectangleImage(Image<Gray, byte> squaredBoundingRectangleImage)
        {
            squaredBiggestContourBoundingRectanglePictureBox.Image = squaredBoundingRectangleImage
                .Resize(Constants.HAND_GESTURE_AREA_WIDTH, Constants.HAND_GESTURE_AREA_HEIGHT, Inter.Linear)
                .ToBitmap();
        }

        private void DrawDataImage(Image<Gray, byte> squaredBoundingRectangleImage)
        {
            dataImagePictureBox.Image = squaredBoundingRectangleImage
                .Resize(dataImagePictureBox.Width, dataImagePictureBox.Height, Inter.Linear)
                .ToBitmap();
        }
    }
}
