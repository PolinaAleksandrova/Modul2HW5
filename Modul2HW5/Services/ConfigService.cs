using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW5.Services.Abstractions;
using Modul2HW5.Configs;

namespace Modul2HW5.Services
{
    public class ConfigService : IConfigService
    {
        private ILogger _logger;
        public ConfigService(ILogger logger)
        {
            _logger = logger;
        }

        public void CreateConfig()
        {
        }

        public void ReadConfig()
        {
        }
    }
}
