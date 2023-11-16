using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizi
{
    internal abstract class Convertitore_Da_CEL_aFar
    {
        private double datiDaConvertire { get; set; }
       
        public abstract void Calcolatore(double datiDaConvertire);
    }
}