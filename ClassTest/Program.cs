using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct");
            Console.WriteLine("=======================");

            Rectangle rect1;
            rect1.length = 100;
            rect1.width = 30;

            Console.WriteLine("rectangle length:{0}, width:{1}", rect1.length, rect1.width);

            Rectangle rect2 = new Rectangle(200, 50);
            Console.WriteLine("rectangle length:{0}, width:{1}, area:{2}",
                rect1.length, rect1.width, rect1.Area());

            Console.WriteLine(String.Empty);
            Console.WriteLine("Class Animal");
            Console.WriteLine("=======================");

            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("fox", "Raaww"));
            animals.Add(new Animal("dog", "Walwal"));
            animals.Add(new Animal("cat", "nyaong"));

            // dictionary 설명하려고 list랑 비교설명. cat 찾기.
            foreach (var animal in animals) 
            {
                var animalName = animal.GetName();
                if(animalName == "cat")
                {
                    Console.WriteLine("Found cat");
                    Console.Write(">>");
                    animal.MakeSound();
                }
            }

            // dictionary 설명하려고 list랑 비교설명. cat 찾기. find함수 이용
            Animal myCat = animals.Find(item => item.GetName().Equals("cat"));  
            if (myCat != null)
            {
                Console.WriteLine("Found my cat again");
                Console.Write(">> ");
                myCat.MakeSound();
            }

            // Dictionmary 이용해서 객체 찾기.
            Console.WriteLine("=======================");
            Dictionary<enAnimalType, Animal> dicAnimals
                = new Dictionary<enAnimalType, Animal>();

            dicAnimals.Add(enAnimalType.fox, new Animal("red", "Raaww"));
            dicAnimals.Add(enAnimalType.dog, new Animal("blue", "walwal"));
            dicAnimals.Add(enAnimalType.cat, new Animal("pink", "nyaong"));

            // dictionary를 이용한 cat 찾기. => 간단.
            var sceneAnimal = dicAnimals[enAnimalType.cat];

            foreach (KeyValuePair<enAnimalType, Animal> item in dicAnimals)
            {
                var key = item.Key;
                var value = item.Value;

                value.MakeSound();
            }

            foreach (var item in dicAnimals.Values)
            {
                item.MakeSound();
            }

            // pig는 입력되어 있지 않음. pig 찾아보고 없으면 없다 출력.
            Console.WriteLine("=======================");
            int count = 0;
            foreach (var animal in animals)
            {
                var animalName = animal.GetName();
                
                if (animalName == "pig")
                {
                    Console.WriteLine("Found pig");
                    Console.Write(">>");
                    animal.MakeSound();
                }
                else
                {
                    count++;
                }

                if (count == 3 /* Animal.GetNumOfAnimals()*/)
                {
                    Console.WriteLine("cannot found pig.");
                }
            }

            //강사님 답. 찾으면 바로 끝. 굳이 뒤를 찾을 필요 없음. => break 사용 이유
            bool bFound = false;
            foreach(var animal in animals)
            {
                var animalName = animal.GetName();
                if(animalName == "pig")
                {
                    bFound = true;
                    break;
                }
            }

            if (bFound)
            {
                Console.WriteLine("pig found");
            }
            else
            {
                Console.WriteLine("pig not found");
            }

            // 없는걸 있다고 착각하고 부르면 프로그램 다운. 그래서 이런 문법 사용. 있나? 물어보고 있으면 출력, 없으면 없다.
            Animal outAnimal;
            if (dicAnimals.TryGetValue(enAnimalType.pig, out outAnimal))
            {
                outAnimal.MakeSound();
            }
            else
            {
                Console.WriteLine("[E] pig not found");
            }

            Console.WriteLine("numOfAnimals : {0}", Animal.GetNumOfAnimals());
            Console.WriteLine(String.Empty);
            Console.WriteLine("ShapeMath");
            Console.WriteLine("=======================");

            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea(enShape.Rectangle, 5, 6));
            Console.WriteLine("Area of Triangle : {0}", ShapeMath.GetArea(enShape.Triangle, 5, 6));
            Console.WriteLine("Area of Circle : {0}", ShapeMath.GetArea(enShape.Circle, 5));

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