using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizi
{
    internal class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"il gatto {base.ToString()} fa Miau");
        }
    }
}
