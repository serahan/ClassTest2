using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest // C#
{
    class Program
    {
        public static object Value { get; private set; }

        static void Main(string[] args)
        {
            //Rectangle rect1;
            //rect1.length = 100;
            //rect1.width = 30;

            //Console.WriteLine("rectangle length : {0}, width : {1}", rect1.length, rect1.width);

            //Rectangle rect2 = new Rectangle(200, 50);
            //Console.WriteLine("rectangle2 length : {0}, width : {1}, area : {2}",
            //    rect2.length, rect2.width, rect2.Area());

            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("fox","Reaww"));
            animals.Add(new Animal("dog", "waw"));
            animals.Add(new Animal("cat", "meow"));

            foreach(var animal in animals)
            {
                animal.MakeSound();
            }

            Dictionary<enAnimalType, Animal> dicAnimals = new Dictionary<enAnimalType, Animal>();
            
            dicAnimals Add(enAnimalType.fox, NewsStyleUriParser Animal("red","Reaww"));
            dicAnimals Add(enAnimalType.dog, NewsStyleUriParser Animal("blue","waw"));
            dicAnimals Add(enAnimalType.cat, NewsStyleUriParser Animal("pink","meow"));

            foreach(KeyValuePair<enAnimalType, Animal> item in dicAnimals)
            {
                var item = item.Key;
                var value = item.Value;

                value MakeSound();
            }

            foreach(var item in dicAnimals Values)
            {
                item MakeSound();
            }

            dicAnimals.Values[0];

            var value = dicAnimals[enAnimalType fox];
            //var fox = new Animal("fox","Reaww");
            //fox.MakeSound();

            //var cat = new Animal("cat", "meow");
            //cat.MakeSound();

            //var dog = new Animal("dog", "waw");
            //dog.MakeSound();

            //int num = Animal.GetNumOfAnimals();
            //Console.WriteLine("numOfAnimals : {0}", num);

            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("rectangle"));
            Console.WriteLine("Area of Triangle : {0}", ShapeMath.GetArea("triangle"));
            Console.WriteLine("Area of Circle : {0}", ShapeMath.GetArea("circle"));
            Console.ReadLine();
        }
        
        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }
    }
}
