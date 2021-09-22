using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Modul2HW5.Services.Abstractions;
using Modul2HW5.Services;
using Modul2HW5.Enums;
using Modul2HW5.Models;

namespace Modul2HW5
{
    public class Application
    {
        private ILogger _logger;
        private IActions _actions;
        public Application(ILogger logger, IActions actions)
        {
            _logger = logger;
            _actions = actions;
        }

        public void Run()
        {
            Random random = new Random();
            var randomMethod = 0;
            for (var i = 0; i < 100; i++)
            {
                randomMethod = random.Next(1, 4);
                try
                {
                    if (randomMethod == 1)
                    {
                        _actions.GetInfo();
                    }
                    else if (randomMethod == 2)
                    {
                        _actions.GetWarning();
                    }
                    else if (randomMethod == 3)
                    {
                        _actions.GetError();
                    }
                }
                catch (BusinessException busException)
                {
                    _logger.WriteMessage($"{DateTime.UtcNow}: {LogType.Warning}: Action got this custom Exception : {busException.Message} ");
                }
                catch (Exception exception)
                {
                    _logger.WriteMessage($"{DateTime.UtcNow}: {LogType.Error}: Action failed by a reason: {exception.Message} ");
                }
            }
        }
    }
}
