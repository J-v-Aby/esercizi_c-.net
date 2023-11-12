using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizi
{
    internal class FahrenheitToCelsius: Convertitore_Da_CEL_aFar
    {
        public override void Calcolatore(double datiDaConvertire)
        {
            double fahrenheit = (datiDaConvertire - 32) * 0.5556;
            Console.WriteLine($"i gradi fahrenheit sono : {fahrenheit}");
        }
    }
}
