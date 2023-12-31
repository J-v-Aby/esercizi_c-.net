﻿using esercizio_SOLID.IMyQueueMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_SOLID
{
    public class IntQueue : MyQueueMethods<int>, IDequeue<int>, IPeek<int>, IQueue<int>
    {
        private MyQueueMethods<int> elemento;

        public IntQueue()
        {
            elemento = new MyQueueMethods<int>();
        }


        public void AddQ(int elemento)
        {
            this.elemento.AddQ(elemento);
        }

        public int DeliteQ()
        {
            return elemento.DeliteQ();
        }

        public int SeeQ()
        {
            return elemento.SeeQ();
        }
    }
}
