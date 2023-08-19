using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionProject2
{
    public class DateTimeService : IDateTimeService
    {
        public string GetDateTimeString()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
