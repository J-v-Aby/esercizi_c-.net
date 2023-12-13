using esercizio_uno;
using System.Xml.Linq;

namespace Secondo_test
{
    public class UnitTest1
    {
        private MyQueue<int> coda;


        public UnitTest1()
        {
            FacciamoContentoAndrea();
        }
        private void FacciamoContentoAndrea()
        {
            if (coda == null)
            {
                coda = new MyQueue<int>();

            }
        }
        [Fact]
        public void AddDeveAggiungereElementoAllaQueue()
        {
            FacciamoContentoAndrea();
            coda.AddQ(42);
        }

        [Fact]
        public void Decoda_DeveRimuovereElementoDallaCodaPiena()
        {
            FacciamoContentoAndrea();
            coda.AddQ(95);
            coda.AddQ(65);

            int elementoRimosso = coda.DeliteQ();

            Assert.Equal(65, (int)coda.DeliteQ());
           
        }

        [Fact]
        public void Decoda_DeveMostriElementoDallaCodaPiena()
        {
            FacciamoContentoAndrea();
            coda.AddQ(95);
            coda.AddQ(65);

            int elementoRimosso = coda.DeliteQ();
            int elementoInVista = coda.SeeQ();

            Assert.Equal(65, (int)coda.SeeQ());
           
        }
    }
}
