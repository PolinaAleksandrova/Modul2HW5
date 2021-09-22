using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW5.Models
{
    public class BusinessException : Exception
    {
        public BusinessException(string warning)
            : base(warning)
        {
        }
    }
}
