using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW5.Services.Abstractions;

namespace Modul2HW5.Services
{
    public class FileService : IFileService
    {
        public void CreateDirectory(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }

        public void WriteToFile(string path, string text)
        {
            File.WriteAllText(path, text);
        }

        public void CountDirectoryFiles(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo fileInfo = new FileInfo(path);
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                if (file.Length > 3)
                {
                }
            }
        }
    }
}
