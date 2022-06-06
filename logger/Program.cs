using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoggeDemo log = new LoggeDemo(@"C:\Users\Fernando\source\repos\logger\logger\");
            log.Add("ocurrion un error");
        }
    }
}
