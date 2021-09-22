using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW5.Services.Abstractions;

namespace Modul2HW5.Services
{
    public class Logger : ILogger
    {
        private IFileService _fileService;
        public Logger(IFileService fileService)
        {
            _fileService = fileService;
        }

        public StringBuilder Sb { get; set; } = new StringBuilder();
        public void WriteMessage(string message)
        {
            Sb.AppendLine(message);
        }

        public void WriteLog()
        {
            _fileService.WriteToFile("log.txt", Sb.ToString());
        }
    }
}
