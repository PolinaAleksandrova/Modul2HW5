using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW5.Services.Abstractions
{
    public interface ILogger
    {
        public void WriteMessage(string message);
        public void WriteLog();
    }
}
