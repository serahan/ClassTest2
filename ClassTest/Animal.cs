using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class Animal
    {
        private string name;
        private string sound;

        public Animal()
        {

        }

        public Animal(string n, string s)
        {
            name = n;
            sound = s;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }
    }
}
