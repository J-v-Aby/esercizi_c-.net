using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizi
{
    internal class Modificari
    {
        private int membroPrivato = 42;
        protected string membroProtetto = "Hello, protected!";
        internal double membroInterno = 3.14;
        public bool membroPubblico = true;

        
        public int OttieniMembroPrivato()
        {
            return membroPrivato;           // Metodo pubblico che restituisce il membro privato
        }

        
       

        
        public double OttieniMembroInterno()
        {
            return membroInterno;           // Metodo pubblico che restituisce il membro interno
        }

       /* // Metodo pubblico che restituisce il membro pubblico
        public bool OttieniMembroPubblico()
        {
            return membroPubblico;
        }*/
    }
}
