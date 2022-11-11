using System;
using Emgu.CV;
using Emgu.CV.Structure;

namespace HandGesturesDataGenerator.Managers
{
    public class TrainingImageDataManager
    {
        private string _imageDataPath;

        public TrainingImageDataManager(string imageDataPath)
        {
            _imageDataPath = imageDataPath;
        }

        public void SaveImageToFile(Image<Gray, byte> imageToSave, string fileName, string imageFormat)
        {
            imageToSave.Save(string.Format(@"{0}\{1}_{2}.{3}", _imageDataPath,
                DateTime.Now.Ticks.ToString(),
                fileName,
                imageFormat));
        }
    }
}