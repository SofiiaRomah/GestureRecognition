using System.IO;
using System.Text;

namespace HandGesturesDataGenerator.Managers
{
    public class CsvManager
    {
        private string _csvPath;
        private string _fileName;

        public CsvManager(string csvPath, string fileName)
        {
            _csvPath = csvPath;
            _fileName = fileName;
        }

        public void AppendLineToFile(string line)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(line);
            File.AppendAllText(string.Format(@"{0}\{1}.csv", _csvPath, _fileName),
                stringBuilder.ToString());
        }

        public string[] ReadAllLines()
        {
            return File.ReadAllLines(string.Format(@"{0}\{1}.csv", _csvPath, _fileName));
        }
    }
}