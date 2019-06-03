using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    public enum enAnimalType
    {
        fox,
        dog,
        cat,
        tiger,
        cow,
        pig,
    }

    class Animal
    {
        static int numOfAnimals = 0;

        private string name;
        private string sound;

        public Animal()
        {
            numOfAnimals++;
        }

        public Animal(string n, string s)
        {
            name = n;
            sound = s;
            numOfAnimals++;
        }

        public string GetName()
        {
            return name;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        public static int GetNumOfAnimals()
        {
            return numOfAnimals;
        }
    }
}