using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizi
{
    internal abstract class Animal
    {
        public String? Name { get;  set; }
        public int Age { get; set; }

        public Animal()
        {
        }
        public Animal(String name, int age)
        {
           Name = name;
            Age = age;
        }

       public abstract void Speak();

        public override string? ToString()
        {
           
            return $" di nome {Name} e di anni {Age}";
        }
    }
}
