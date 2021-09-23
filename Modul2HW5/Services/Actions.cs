using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW5.Models;
using Modul2HW5.Services.Abstractions;
using Modul2HW5.Enums;

namespace Modul2HW5
{
    public class Actions : IActions
    {
        private ILogger _logger;
        public Actions(ILogger logger)
        {
            _logger = logger;
        }

        public bool GetInfo()
        {
            _logger.WriteMessage($"{DateTime.Now}:{LogType.Info} : Start method: GetInfo");
            return true;
        }

        public bool GetWarning()
        {
            throw new BusinessException("Skipped logic in method");
        }

        public bool GetError()
        {
            throw new Exception("I broke a logic");
        }
    }
}
