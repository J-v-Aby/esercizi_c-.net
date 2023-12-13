using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_SOLID.IMyQueueMethods
{
    public class Logger : ILogger
    {
        void ILogger.Logger(string v)
        {
            Console.WriteLine(v);
        }
    }
}
