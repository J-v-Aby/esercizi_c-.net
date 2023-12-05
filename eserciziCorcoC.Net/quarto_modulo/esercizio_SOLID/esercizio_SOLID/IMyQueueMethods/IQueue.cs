using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_SOLID.IMyQueueMethods
{
    public interface IQueue<T>
    {
        public void AddQ(T elemento);
    }
}
