using esercizio_uno;
using System.Collections.Generic;

namespace Test_esercizio1
{
    public class UnitTest1
    {
        [Fact]
        public void AddDeveAggiungereElementoAllaQueue()
        {
            MyQueue<int> coda = new MyQueue<int>();

             coda.AddQ(42);

           // Assert.Equal(42, (int)coda.AddQ());
        }

        [Fact]
        public void Decoda_DeveRimuovereElementoDallaCodaVuota()  // eccezione perche vuoto vuoto
        {
            MyQueue<int> coda = new MyQueue<int>();

            int elementoRimosso = coda.DeliteQ();

            Assert.Equal(42, (int)coda.DeliteQ());
        }
        [Fact]
        public void Decoda_DeveRimuovereElementoDallaCodaPiena()  
        {
            MyQueue<int> coda = new MyQueue<int>();
            coda.AddQ(95);
            coda.AddQ(65);
           
            int elementoRimosso = coda.DeliteQ();

            Assert.Equal(65, (int)coda.DeliteQ());
        }

        [Fact]
        public void Decoda_DeveMostriElementoDallaCodaVuota()  // eccezione perche vuoto vuoto
        {
            MyQueue<int> coda = new MyQueue<int>();
            coda.AddQ(95);
            int elementoRimosso = coda.DeliteQ();
            int elementoInVista = coda.SeeQ();

            Assert.Equal(95, (int)coda.SeeQ());
        }
        [Fact]
        public void Decoda_DeveMostriElementoDallaCodaPiena()
        {
            MyQueue<int> coda = new MyQueue<int>();
            coda.AddQ(95);
            coda.AddQ(65);

            int elementoRimosso = coda.DeliteQ();
            int elementoInVista = coda.SeeQ();

            Assert.Equal(65, (int)coda.SeeQ());
        }
    }
}