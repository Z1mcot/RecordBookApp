using System;
using System.Collections.Generic;
using System.IO;

namespace RecordBookApp.Services
{
    public class FileService<T> where T : new()
    {
        readonly string _workingDirectory;

        public FileService(string workingDirectory = "../../io")
        {
            if (!Directory.Exists(workingDirectory))
            {
                Directory.CreateDirectory(workingDirectory);
            }
            _workingDirectory = workingDirectory;
        }

        public List<T> ReadFromFile(string fileName)
        {
            List<T> fileInfo = new List<T>();
            string fullPath = Path.Combine(_workingDirectory, fileName);

            if (File.Exists(fullPath))
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        if (!string.IsNullOrEmpty(line))
                        {
                            T anotherPieceOfInfo = (T)Activator.CreateInstance(typeof(T), args: line);
                            fileInfo.Add(anotherPieceOfInfo);
                        }
                    }
                }
            }

            return fileInfo;
        }

        public void WriteToFile(List<T> info, string fileName)
        {
            string fullPath = Path.Combine(_workingDirectory, fileName);

            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                foreach (T item in info)
                {
                    sw.WriteLine(item.ToString());
                }
            }
        }
    }
}
