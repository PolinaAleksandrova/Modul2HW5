using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW5.Services.Abstractions;
using Modul2HW5.Configs;

namespace Modul2HW5.Services
{
    public class Logger : ILogger
    {
        private IFileService _fileService;
        private IConfigService _configService;

        public Logger(IFileService fileService, IConfigService configService)
        {
            _fileService = fileService;
            _configService = configService;
        }

        public LoggerConfig LoggerConfig => _configService.Config.LoggerConfig;
        public StringBuilder Sb { get; set; } = new StringBuilder();
        public void WriteMessage(string message)
        {
            Sb.AppendLine(message);
        }

        public void WriteLog()
        {
            _fileService.WriteToFile($"{LoggerConfig.DirectoryPath}{DateTime.UtcNow.ToString(LoggerConfig.FileName)}{LoggerConfig.FileExtension}", Sb.ToString());
        }
    }
}
