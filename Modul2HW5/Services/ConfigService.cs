using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Modul2HW5.Services.Abstractions;
using Modul2HW5.Configs;
using Newtonsoft.Json;

namespace Modul2HW5.Services
{
    public class ConfigService : IConfigService
    {
        private Config _config;
        public Config Config
        {
            get
            {
                return _config;
            }
        }

        public void CreateConfig()
        {
            var config = new Config()
            {
                LoggerConfig = new LoggerConfig()
                {
                    LineSeparator = 10,
                    TimeFormat = "hh:mm:ss",
                    DirectoryPath = "Logs/",
                    FileName = "hh.mm.ss dd.MM.yyyy",
                    FileExtension = ".txt"
                }
            };
            var json = JsonConvert.SerializeObject(config);
            File.WriteAllText("config.json", json);
        }

        public void ReadConfig()
        {
            var configFile = File.ReadAllText("config.json");
            _config = JsonConvert.DeserializeObject<Config>(configFile);
        }
    }
}
