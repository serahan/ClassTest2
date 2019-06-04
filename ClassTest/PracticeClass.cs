using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    public static class PracticeClass
    {
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

        public static void practice1()
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

            for (int i = 0; i < animals.Count; i++)
            {
                Animal thisAnimal = animals[i];
            }

            bool bFound = false;
            foreach (var animal in animals)
            {
                var animalName = animal.GetName();
                if (animalName == "pig")
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

            Animal myPig = null;
            myPig = animals.Find(item => item.GetName().Equals("pig"));
            if (myPig != null)
            {
                Console.WriteLine("pig found");
                myPig.MakeSound();
            }
            else
            {
                Console.WriteLine("pig not found");
            }

            Dictionary<enAnimalType, Animal> dicAnimals
                = new Dictionary<enAnimalType, Animal>();

            dicAnimals.Add(enAnimalType.fox, new Animal("red", "Raaww"));
            dicAnimals.Add(enAnimalType.dog, new Animal("blue", "walwal"));
            dicAnimals.Add(enAnimalType.cat, new Animal("pink", "nyaong"));

            var someAnimal = dicAnimals[enAnimalType.cat];

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
        }

        public static void practice2()
        {
            //string str = "Kunsan University";
            //Console.WriteLine(str.ToLower());
            //Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str.Contains("Kunsan));
            //Console.WriteLine(str.Contains("kunsan"));
            //Console.WriteLine(str[0]); // K 출력
            //Console.WriteLine(str[7]); // U 출력
            //Console.WriteLine(str.IndexOf("University"));
            //Console.WriteLine(str.IndexOf("U"));
            //Console.WriteLine(str.IndexOf('U'));
            //Console.WriteLine(str.Substring(2,5));
            //Console.WriteLine(str.Substring(str.IndexOf("University"))); // IndexOf : 7부터 , Substring : 끝까지

            //example 1
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0;i < 10; i++)
            //{
            //    sb.Append(i).Append(" ");
            //}
            //Console.WriteLine(sb.ToString());

            //example 2
            //StringBuilder sb2 = new StringBuilder();
            //sb2.Append("The list starts here: ");
            //sb2.AppendLine();
            //sb2.Append("1 cat").AppendLine();

            //string str2 = sb2.ToString();
            //Console.WriteLine(str2);

            //example 3
            //StringBuilder sb3 = new StringBuilder(
            //    "Korea University");
            //sb3.Replace("Korea","Kunsan");
            //Console.WriteLine(sb3.ToString());

            //example 4
            //string[] items = { "Cat", "Dog", "Fox", "Pig" };

            //StringBuilder sb4 = new StringBuilder(
            //    "These animals are required:").AppendLine();

            //foreach(string item in items)
            //{
            //    sb4.Append(item).AppendLine();
            //}

            //Console.WriteLine(sb4.ToString());

            //example 5
            //StringBuilder sb5 = new StringBuilder("Kunsan is University");
            //sb5.Remove(7, 3);

            //Console.WriteLine(sb5.ToString());

            //example 6
            //StringBuilder sb6 = new StringBuilder();
            //sb6.Append("Kunsan University.");

            //TrimEnd(sb6);
            //Console.WriteLine(sb6.ToString());

            //example 7
            StringBuilder sb6 = new StringBuilder();
            sb6.Append("Kunsan University.");

            TrimEnd(sb6, '.');
            Console.WriteLine(sb6.ToString());
        }

        public static void practice3()
        {
            //Console.WriteLine(5 + 8);
            //Console.WriteLine(5 * 8);
            //Console.WriteLine(4 + 5 * 2);
            //Console.WriteLine(5 / 2);
            //Console.WriteLine(5 / 2.0);
            //Console.WriteLine(Math.Abs(-5)); // 절댓값
            //Console.WriteLine(Math.Pow(5,3)); // 거듭제곱
            //Console.WriteLine(Math.Ceiling(18.8)); // 소숫값 올림 정수값 반환 math.ceiling에 2가지 함수 존재. decimal과 double.
            //Console.WriteLine(Math.Ceiling(18.8m));
            //Console.WriteLine(Math.Floor(18.8m));  // 소숫값 내림 정수값 반환.
            //Console.WriteLine(Math.Sqrt(10.2)); // square root. 제곱근.
            Tuple<string, double>[] areas =
                { Tuple.Create("Sitka, Alaska",2070.3),
                  Tuple.Create("New York City", 302.6),
                  Tuple.Create("Los Angeles", 468.7),
                  Tuple.Create("Detroit", 138.8),
                  Tuple.Create("Chicago", 227.1),
                  Tuple.Create("San Diego",325.2)
            };

            Console.WriteLine("{0,-18} {1,14:N1} {2,30}\n", "City", "Area (mi.)",
                "Equivalent to a square with:");

            foreach (var area in areas)
                Console.WriteLine("{0,-18} {1, 14:N1} {2, 14:N2} miles per side",
                    area.Item1, area.Item2, Math.Round(Math.Sqrt(area.Item2), 2));

            //Console.WriteLine(Math.Max(2,5));
            //Console.WriteLine(Math.Min(10,2));
            //Console.WriteLine(Math.Atan(10.2));
        }
        public static void TrimEnd(StringBuilder sb, char c)
        {
            //example 7-1) 뒤에거 삭제
            //int end_num = sb.Length - 1;
            //sb.Remove(end_num, 1);

            //example 7 - 2) 뒤에가.이면 삭제.
            //int end_num = sb.Length - 1;

            //if (sb[end_num] == c)
            //{
            //    sb.Remove(end_num, 1);
            //}

            //강사 example 7-2 + 길이가 0일 때 에러 안나게.
            //if(sb.Length ==0)
            //{
            //    return;
            //}
            //if (sb[sb.Length - 1] == c)
            //{
            //    sb.Length -= 1;
            //}
            //////////////////////////////////////////////
        }
    }
}