using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizi
{
    internal class Modificatori2 :Modificari
    {
        public string OttieniMembroProtetto()
        {
            return membroProtetto;          // Metodo pubblico che restituisce il membro protetto
        }
    }
}
