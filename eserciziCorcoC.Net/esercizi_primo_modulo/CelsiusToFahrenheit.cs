using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizi
{
    internal class CelsiusToFahrenheit : Convertitore_Da_CEL_aFar
    {
        public override void Calcolatore(double datiDaConvertire)
        {
            double celsius = (datiDaConvertire * 1.8) + 32;
            Console.WriteLine($"i gradi celsius sono : {celsius}");
        }
    }
}
