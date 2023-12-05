using esercizio_SOLID.IMyQueueMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_SOLID
{
    public class MyQueueMethods<T>:IDequeue<T>,IPeek<T>,IQueue<T>
    {
        private Queue<T> elemento;

        public MyQueueMethods()
        {
            elemento = new Queue<T>();
        }

        
        public void AddQ(T elemento)
        {
            this.elemento.Enqueue(elemento);
        }

        
        public T DeliteQ()
        {
            if (elemento.Count == 0)
            {
                Console.WriteLine("La coda è vuota");
            }

            return elemento.Dequeue();
        }

        
        public T SeeQ()
        {
            if (elemento.Count == 0)
            {
                Console.WriteLine("La coda è vuota");
            }

            return elemento.Peek();
        }

    }
}
