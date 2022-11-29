using System.IO;
using System.Text;

namespace GestureRecognition.Managers
{
    public class CsvManager
    {
        private readonly string _csvPath;
        private readonly string _fileName;

        public CsvManager(string csvPath, string fileName)
        {
            _csvPath = csvPath;
            _fileName = fileName;
        }

        public void AppendLineToFile(string line)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(line);
            File.AppendAllText($@"{_csvPath}\{_fileName}.csv",
                stringBuilder.ToString());
        }

        public string[] ReadAllLines()
        {
            return File.ReadAllLines($@"{_csvPath}\{_fileName}.csv");
        }
    }
}