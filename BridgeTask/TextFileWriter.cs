using System;
using System.IO;
using System.Text;

namespace BridgeTask
{
    public class TextFileWriter:IWriter
    {
        private string _fileName;

        public string FileName
        {
            get => _fileName;
            set => _fileName = FileHelper.GetSafeFileName(".txt", value);
        }

        public TextFileWriter(string fileName)
        {
            FileName = fileName;
        }
        public void Write(string data)
        {
            using (FileStream fs = new FileStream(FileName, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine(data);
                    sw.WriteLine(new string('-', 40));
                }
            }
        }
    }
}