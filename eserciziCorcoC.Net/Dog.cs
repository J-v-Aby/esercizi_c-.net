using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizi
{
    internal class Dog : Animal
    {
        public override void Speak() 
        {
            Console.WriteLine($"il cane{ base.ToString()} fa Bau");
        }
    }
}
