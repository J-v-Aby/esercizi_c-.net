using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_SOLID
{
    public class StringQueue
    {
        private MyQueueMethods<string> elemento;

        public StringQueue()
        {
            elemento = new MyQueueMethods<string>();
        }


        public void AddQString(string elemento)
        {
            this.elemento.AddQ(elemento);
        }


        public string DeliteQString()
        {
            return elemento.DeliteQ();
        }


        public string SeeQString()
        {
            return elemento.SeeQ();
        }
    }
}

