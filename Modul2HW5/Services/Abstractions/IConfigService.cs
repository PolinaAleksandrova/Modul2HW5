using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW5.Configs;

namespace Modul2HW5.Services.Abstractions
{
    public interface IConfigService
    {
        public Config Config { get; }
        public void CreateConfig();
        public void ReadConfig();
    }
}
