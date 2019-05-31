using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest // C#
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle rect1;
            //rect1.length = 100;
            //rect1.width = 30;

            //Console.WriteLine("rectangle length : {0}, width : {1}", rect1.length, rect1.width);

            //Rectangle rect2 = new Rectangle(200, 50);
            //Console.WriteLine("rectangle2 length : {0}, width : {1}, area : {2}",
            //    rect2.length, rect2.width, rect2.Area());

            Animal fox = new Animal("fox","Reaww");
            fox.MakeSound();
           
            Animal cat = new Animal("cat", "meow");
            cat.MakeSound();

            Animal dog = new Animal("dog", "waw");
            dog.MakeSound();

            int num = Animal.GetNumOfAnimals();
            Console.WriteLine("numOfAnimals : {0}", num);
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
