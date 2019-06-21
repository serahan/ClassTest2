using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

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
            //StringBuilder sb6 = new StringBuilder();
            //sb6.Append("Kunsan University.");

            //TrimEnd(sb6, '.');
            //Console.WriteLine(sb6.ToString());
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

        public static void practice4()
        {
            //example 1
            //string name = "";

            //Console.WriteLine("Enter your name");
            //name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);

            //example 2
            string ID = "Kunsan";
            string PW = "ABCDefg";
            string User_ID = "";
            string User_PW = "";

            ID = ID.ToLower();

            Console.WriteLine("Enter your ID : ");
            User_ID = Console.ReadLine();
            Console.WriteLine("Enter your PW : ");
            User_PW = Console.ReadLine();
            User_ID = User_ID.ToLower();

            if (ID != User_ID)
            {
                Console.WriteLine("아이디가 다릅니다.");
            }
            else if (PW != User_PW)
            {
                Console.WriteLine("비밀번호가 다릅니다.");
            }
            else
            {
                Console.WriteLine("환영합니다.");
            }

        }

        public static void practice5()
        {
            // 한 학급에 5명의 학생이 있고, 각 학생당 국영수 세과목 점수가 배열에 저장되어 있을 때,
            // 각 학생별 국영수 합계 및 그 평균을 출력하는 프로그램을 작성하세요.
            // 2차원 배열 사용

            // (점수데이터)
            // 90, 80, 90
            // 85, 85, 85
            // 95, 70, 75
            // 80, 80, 90
            // 90, 75, 80

            // [출력결과]
            // ID=0 : 합계=260, 평균=86.67
            // ID=1 : 합계=260, 평균=86.67
            // ID=2 : 합계=260, 평균=86.67
            // ID=3 : 합계=260, 평균=86.67
            // ID=4 : 합계=260, 평균=86.67

            int[,] arr = new int[,] { { 90, 80, 90 }, { 85, 85, 85 }, { 95, 70, 75 }, { 80, 80, 90 }, { 90, 75, 80 } };

            //int[,] arr = new int[5, 3];

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arr[i, j] = (int)Console.Read();
            //    }
            //}
            double[] avg = new double[5];
            int[] sum = new int[5];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum[i] += arr[i, j];
                }
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    avg[i] = (double)sum[i] / 3;
                }
            }

            for (int id = 0; id < 5; id++)
            {
                Console.WriteLine("ID={0} : 합계={1}, 평균={2}", id, sum[id], avg[id]);
            }

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
            //}
        }

        public static void practice6()
        {
            // 한 문자열의 대문자는 소문자로, 소문자는 대문자로 변경하는 프로그램을 작성하세요.

            // 원문 : Hello World
            // hELLO wORLD

            //string[] str = { "Hello World" } ;

            //for(int i=0;i<11;i++)
            //{
            //    char input = str[i].ToString();
            //    if (('A' <= str[i]) && (str[i] >= 'Z'))
            //    {
            //        str[i] = str[i].ToLower();
            //    }
            //    else if(('a'<=str[i]) && (str[i] >= str[i]))
            //    {
            //        str[i] = str[i].ToUpper();
            //    }
            //}

            string s = "Hello, World";
            string result = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                char t = s[i];
                if (char.IsUpper(t))
                {
                    t = char.ToLower(t);
                }
                else if (char.IsLower(t))
                {
                    t = char.ToUpper(t);
                }
                result = result + t;
            }
            Console.WriteLine(result);
        }

        public static void practice7()
        {
            // "Hello World"를 시저의 암호화 기법을 이용하여 "Khoor Zruog"으로 출력하는 프로그램

            // [결과]
            // 원문 : Hello World
            // 암호 : Khoor Zruog

            string str = "Hello World";

            Console.WriteLine("원문 : " + str);
            Console.Write("암호 : ");
            for (int i = 0; i < str.Length; i++)
            {
                char t = str[i];

                if ((65 <= (char)str[i] + 3) && ((char)str[i] + 3 <= 90) ||
                    (97 <= (char)str[i] + 3) && ((char)str[i] + 3) <= 122)
                {
                    t = (char)(str[i] + 3);
                }
                Console.Write(t);
            }









            // 강사 풀이
            //string plaintText = "Hello World";

            //StringBuilder sb = new StringBuilder();

            //foreach(char ch in plaintText)
            //{
            //    char newchar = ch;

            //    if((ch>='A' && ch <= 'Z')||(ch>='a' && ch <= 'z'))
            //    {
            //        newchar = (char)(ch + 3);

            //        if((Char.IsUpper(ch) && newchar>'Z') || (Char.IsLower(ch) && newchar > 'z'))
            //        {
            //            newchar = (char)(newchar - 26);
            //        }
            //    }
            //    sb.Append(newchar);
            //}
            //Console.WriteLine(sb.ToString());
        }

        public static void practice8()
        {
            // 임의의 정의 값들을 배열로 받아들여, 그 합계를 구하는 메서드(함수)를 작성하세요.

            // [결과화면]
            // A : 80, 90, 95, 75, 70
            // Sum(A) = 410

            // B : 90, 85, 85, 85, 80
            // Sum(B) = 425

            int[] arr1 = { 80, 90, 95, 75, 70 };
            int[] arr2 = { 90, 85, 85, 85, 80 };


            Console.Write("A :");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            // Console.WriteLine("A : {0}", string.Join<int>(",", arr1));

            Console.Write("\n");
            Console.WriteLine("Sum(A) : {0}", MakeSum(arr1));

            Console.Write("B :");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.Write("\n");
            Console.WriteLine("Sum(B) : {0}", MakeSum(arr2));

        }

        public static int MakeSum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static void practice9()
        {
            // 2개의 정수 값을 받아들여 덧셈, 뺄셈, 곱셈, 나눗셈을 각각 수행하는 4개의 메서드를 작성하시오.
            // 이들 메서드를 사용하여 아래와 같은 계산식의 결과를 출력하시오.

            // (3 + 5 - 2) x 2 / 3 = 4

            int x = Add(3, 5);
            x = Minus(x, 2);
            x = Mul(x, 2);
            x = Div(x, 3);

            Console.Write("(3 + 5 - 2) x 2 / 3 = ");
            Console.WriteLine(x);

        }

        public static int Add(int input1, int input2)
        {
            return input1 + input2;
        }
        public static int Minus(int input1, int input2)
        {
            return input1 - input2;
        }
        public static int Mul(int input1, int input2)
        {
            return input1 * input2;
        }
        public static int Div(int input1, int input2)
        {
            return input1 / input2;
        }

        public static void practice10()
        {
            // 다음과 같은 조건을 갖는 삼각형(Trinangle) 클래스를 작성하세요.

            // [조건]
            // 삼각형은 세변의 길이를 가지고 있으며,
            // 클래스로부터 객체를 생성할 때 세변의 길이가 주어져야 한다.
            // 클래스는 삼각형의 주변 둘레를 알려줄 수 있다.
            // 클래스는 삼각형을 그리는 기능을 갖는다.여기서는 실제 삼각형을 그리기보다는
            // "Draw(a,b,c)" 라는 문자열을 출력하는 코드로 구현한다.(a,b,c = 각변의 길이)

            Triangle tri1 = new Triangle(3, 5, 4);
            Triangle tri2 = new Triangle(3, 3, 3);

            Console.Write("삼각형1 : ");
            Console.WriteLine("A = {0}, B = {1}, C = {2}", tri1.A, tri1.B, tri1.C);
            Console.WriteLine("둘레길이 : " + tri1.MakeSumLength);

            Console.WriteLine("\n");

            Console.Write("삼각형2 : ");
            Console.WriteLine("A = {0}, B = {1}, C = {2}", tri2.A, tri2.B, tri2.C);
            tri2.Draw();
        }

        public static void practice11()
        {
            FourFunction four = new FourFunction();
            Console.Write("a=");
            four.A = 20; // Console.Read();
            Console.Write(four.A);
            Console.Write("  b=");
            four.B = 10; // Console.Read();
            Console.WriteLine(four.B);
            Console.WriteLine("사칙연산 결과: {0}, {1}, {2}, {3}", four.Add(four.A, four.B), four.Sub(four.A, four.B), four.Mul(four.A, four.B), four.Div(four.A, four.B));

            Console.WriteLine("");
            Console.Write("c=");
            four.C = 20.5;
            Console.Write(four.C);
            Console.Write("  d=");
            four.D = 10.5;
            Console.WriteLine(four.D);
            Console.WriteLine("사칙연산 결과 : {0}, {1}, {2}, {3:N6}", four.Add(four.C, four.D), four.Sub(four.C, four.D), four.Mul(four.C, four.D), four.Div(four.C, four.D));
        }

        public static void practice12()
        {
            FourFuncGeneric<int> four1 = new FourFuncGeneric<int>();
            four1.A = 10;
            four1.B = 20;
            Console.WriteLine("사칙연산 결과: {0}, {1}, {2}, {3}", four1.Add(four1.A, four1.B), four1.Sub(four1.A, four1.B), four1.Mul(four1.A, four1.B), four1.Div(four1.A, four1.B));

            FourFuncGeneric<double> four2 = new FourFuncGeneric<double>();
            four2.A = 20.5;
            Console.WriteLine("a={0}", four2.A);
            four2.B = 10.5;
            Console.WriteLine("b={0}", four2.B);
            Console.WriteLine("사칙연산 결과 : {0}, {1}, {2}, {3}", four2.Add(four2.A, four2.B), four2.Sub(four2.A, four2.B), four2.Mul(four2.A, four2.B), four2.Div(four2.A, four2.B));
        }

        public static void practice13()
        {
            Car car = new Car("자동차");

            car.Start();
            Console.WriteLine("시작시 속도 : {0}", car.Speed);
            car.Accelerate();
            Console.WriteLine("엑셀 1단계 속도 : {0}", car.Speed);
            car.Accelerate();
            Console.WriteLine("엑셀 2단계 속도 : {0}", car.Speed);
            car.Stop();
            Console.WriteLine("정지후 속도 : {0}", car.Speed);
        }

        public static void practice14()
        {
            MyPaint paint = new MyPaint();

            TriangleDraw t = new TriangleDraw(3, 4, 5);
            paint.DrawShape(t);
            Console.WriteLine();

            RectangleDraw r = new RectangleDraw(5, 5);
            paint.DrawShape(r);
            Console.WriteLine();

            CustomShape c = new CustomShape(3, 3, 3, 3);
            paint.DrawShape(c);
            Console.WriteLine();

        }

        public static void practice15() // ppt practice#16 employee class 상속
        {
            FullTimeEmployee park = new FullTimeEmployee("park", 1234);
            park.AnnualSalary = 10000;
            park.AdjustSalary(100);
            Console.WriteLine("{0}'s annual salary is {1}", park.Name, park.AnnualSalary);
            park.SayName();

            PartTimeEmployee choi = new PartTimeEmployee("choi");
            choi.TimelySalary = 100;
            int workHour = 8;
            int totalPayment = choi.CalculatePay(workHour);
            Console.WriteLine("{0}'s work hour is {1}, total payment is {2}", choi.Name, workHour, totalPayment);
            choi.SayName();
        }

        public static void practice16()
        {
            try
            {
                using (StreamReader sr = new StreamReader("score.txt"))
                {
                    //라인 읽기
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);

                        string[] split = line.Split(',');
                        int num1 = 0, num2 = 0, num3 = 0;
                        double avg = 0.0;

                        num1 = int.Parse(split[1]);
                        num2 = int.Parse(split[2]);
                        num3 = int.Parse(split[3]);
                        avg = (double)(num1 + num2 + num3) / 3;

                        Console.WriteLine(line);
                        Console.WriteLine($"합계 : {num1 + num2 + num3}");
                        Console.WriteLine($"평균 : {avg}");
                        // {int.Parse(split[1]) + int.Parse(split[2]) + int.Parse(split[3])}
                    }

                    // 한 문자 읽기
                    //int ch = sr.Read();
                    //char[] buffer = new char[10];
                    //sr.Read(buffer, 0, 10);
                    //Console.WriteLine(buffer);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public static void practice17()
        {
            A Test1 = new A();
            B Test2 = new B();

            Test1.EventHandler += new DelegateType(Test2.PrintA);
            Test1.EventHandler += new DelegateType(Test2.PrintB);
            Test1.Func("Good!!");
            Test1.EventHandler -= Test2.PrintB;
            Test1.Func("Hi~~!");
            Test1.EventHandler -= Test2.PrintA;

            Test1.EventHandler += Test2.PrintA; // 처리기에 추가하기
            Test1.EventHandler += Test2.PrintB;

            Test1.Func("Hello World");
        }

        public static void practice18()
        {
            
        }
    }

    class Program
    {
        static void Func()
        {
            Console.WriteLine("스레드에서 호출");
        }

        static void ParameterizedFunc2(object obj)
        {
            for (int i = 0; i < (int)obj; i++)
            {
                Console.WriteLine("Parameterized 스레드에서 호출 : {0}", i);
            }
        }
        

    }

    delegate void DelegateType(string message); // practice17

    class A // practice17
    {
        public event DelegateType EventHandler;

        public void Func(String Message)
        {
            EventHandler(Message);
        }
    }

    class B // practice17
    {
        public void PrintA(string Message)
        {
            Console.WriteLine(Message);
        }
        public void PrintB(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}

class Employee
{
    public string Name { get; set; }
    public string email { get; set; }

    public Employee(string name)
    {
        this.Name = name;
    }
    public virtual void SayName()
    {
        Console.WriteLine($"My name is {Name}");
    }
}// practice15

class FullTimeEmployee : Employee
{
    private int EmployeeNumber { get; set; }

    public FullTimeEmployee(string name, int number) : base(name)
    {
        EmployeeNumber = number;
    }

    public int AnnualSalary { get; set; }

    public void AdjustSalary(int amount)
    {
        this.AnnualSalary += amount;
    }
    public override void SayName()
    {
        //base.SayName();
        Console.WriteLine($"My number is {EmployeeNumber}, name is {Name}");
    }
} // practice15

class PartTimeEmployee : Employee
{
    public PartTimeEmployee(string name) : base(name)
    {
        this.Name = name;
    }
    public int TimelySalary { get; set; }

    public int CalculatePay(int time)
    {
        return time * TimelySalary;
    }
    public override void SayName()
    {
        Console.WriteLine($"My name is {Name}");
    }
} // practice15

interface IDrawable
{
    void Draw(); // interface => interface 내에 있는 함수를 꼭 가져야 한다.
} // practice15

class MyPaint
{
    List<IDrawable> drawables = new List<IDrawable>();

    public void DrawShape(IDrawable shape)
    {
        drawables.Add(shape);

        foreach (IDrawable drawble in drawables)
        {
            drawble.Draw();
        }
    }
} // practice15

class TriangleDraw : IDrawable
{
    private int length1 = 0;
    private int length2 = 0;
    private int length3 = 0;

    public TriangleDraw(int a, int b, int c)
    {
        this.length1 = a;
        this.length2 = b;
        this.length3 = c;
    }
    public void Draw()
    {
        Console.WriteLine($"Draw triangle({length1},{length2},{length3})");
    }

} // practice15

class RectangleDraw : IDrawable
{
    private int width = 0;
    private int height = 0;

    public RectangleDraw(int a, int b)
    {
        this.width = a;
        this.height = b;
    }
    public void Draw()
    {
        Console.WriteLine("Draw rectangle({0}, {1})", width, height);
    }
} // practice15

class CustomShape : IDrawable
{
    private int width = 0;
    private int height = 0;
    private int x = 0;
    private int y = 0;

    public CustomShape(int a, int b, int c, int d)
    {
        this.width = a;
        this.height = b;
        this.x = c;
        this.y = d;
    }
    public void Draw()
    {
        Console.WriteLine("Draw customShape({0}, {1}, {2}, {3})", width, height, x, y);
    }
} // practice15

public class Car
{
    public string maker
    {
        get;
        set;
    }
    public string model
    {
        get;
        set;
    }

    private string name
    {
        get;
        set;
    }
    private int speed;

    public Car(string Name)
    {
        name = Name;
    }

    public int Speed
    {
        get { return this.speed; }
    }

    public void Start()
    {
        this.speed = 1;
    }
    public void Stop()
    {
        this.speed = 0;
    }
    public void Accelerate()
    {
        this.speed += 10;
    }
    public void Break()
    {
        this.speed -= 10;
    }
}

public class Triangle
{
    private double length1 = 0;
    private double length2 = 0;
    private double length3 = 0;

    public Triangle(double a, double b, double c) // 생성자
    {
        this.length1 = a;
        this.length2 = b;
        this.length3 = c;
    }

    public double A // 속성
    {
        get { return this.length1; }
    }

    public double B // 속성
    {
        get { return this.length2; }
    }

    public double C // 속성
    {
        get { return this.length3; }
    }

    public double MakeSumLength // 속성
    {
        // return this.length1 + this.length2 + this.length3;
        get { return this.length1 + this.length2 + this.length3; }
    }

    public void Draw() // 메소드
    {
        Console.WriteLine("Draw({0},{1},{2})", this.length1, this.length2, this.length3);
        Console.WriteLine("둘레길이 : {0}, {1}, {2}", this.length1, this.length2, this.length3);
    }

    // 강사 풀이
    //List<Triangle1> triangles = new List<Triangle1>();
    //triangles.Add(new Triangle1(3, 4, 5));
    //        triangles.Add(new Triangle1(3, 3, 3));
    //        triangles.Add(new Triangle1(5, 4, 3));

    //        int index = 1;
    //        foreach(Triangle1 shape in triangles)
    //        {
    //            shape.Draw(index);
    //            index++;
    //        }
}

public class FourFunction // practice11 사칙연산 ppt #13-1
{
    private int IntNumber1 = 0;
    private int IntNumber2 = 0;
    private double DoubleNumber1 = 0.0;
    private double DoubleNumber2 = 0.0;

    public int A
    {
        get { return this.IntNumber1; }
        set { this.IntNumber1 = value; }
    }

    public int B
    {
        get { return this.IntNumber2; }
        set { this.IntNumber2 = value; }
    }

    public double C
    {
        get { return this.DoubleNumber1; }
        set { this.DoubleNumber1 = value; }
    }

    public double D
    {
        get { return this.DoubleNumber2; }
        set { this.DoubleNumber2 = value; }
    }

    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Sub(int a, int b)
    {
        return a - b;
    }
    public int Mul(int a, int b)
    {
        return a * b;
    }
    public double Div(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("0으로 나눌 수 없습니다.");
            return 0;
        }
        return (double)a / b; // return a * 1.0 / b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Sub(double a, double b)
    {
        return a - b;
    }
    public double Mul(double a, double b)
    {
        return a * b;
    }
    public double Div(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("0으로 나눌 수 없습니다.");
            return 0;
        }
        return a / b;
    }
}

public class FourFuncGeneric<T> where T : struct, IConvertible // where T : struct // practice12 사칙연산 제네릭 클래스 ppt #13-2
{
    private T data1;
    private T data2;

    public T A
    {
        set { this.data1 = value; }
        get { return this.data1; }
    }

    public T B
    {
        set { this.data2 = value; }
        get { return this.data2; }
    }

    public T Add(T a, T b)
    {
        dynamic da = a;
        dynamic db = b;

        return da + db;
    }
    public T Sub(T a, T b)
    {
        dynamic da = a;
        dynamic db = b;

        return da - db;
    }
    public T Mul(T a, T b)
    {
        dynamic da = a;
        dynamic db = b;

        return da * db;
    }
    public T Div(T a, T b)
    {
        dynamic da = a;
        dynamic db = b;

        return da / db;
    }
}

