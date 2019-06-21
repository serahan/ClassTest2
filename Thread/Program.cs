using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace Thread_1
{
    class Test
    {
        public void Print()
        {
            Console.WriteLine("스레드 호출");
        }
    }

    class Program
    {
        static void Func1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("스레드 호출1 {0}", i);
            }
        }

        static void Func2()
        {
            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine("스레드 호출2 {0}", i);
            }
        }

        static void Func()
        {
            Console.WriteLine("스레드에서 호출");
        }

        static void ParameterizedFunc2(object obj)
        {
            for(int i=0;i<(int)obj;i++)
            {
                Console.WriteLine("Parameterized 스레드에서 호출 : {0}", i); ;
            }
        }

        static void Main(string[] args)
        {
            //Thread th = new Thread(new ThreadStart(Func));
            //ThreadStart thStart = new ThreadStart(Func);
            //Thread th = new Thread(thStart);
            //th.Start();

            //int i = 5;
            //Thread th2 = new Thread(new ParameterizedThreadStart(ParameterizedFunc2));
            //th2.Start(i);

            ////Thread th = new Thread(new ThreadStart(Func));

            //ThreadStart thStart = new ThreadStart(Func);
            //Thread th = new Thread(thStart);
            //th.Start();

            //=====================================================

            //Test test1 = new Test();
            //Test test2 = new Test();

            //Thread th1 = new Thread(new ThreadStart(test1.Print));
            //Thread th2 = new Thread(new ThreadStart(test2.Print));

            //th1.Start();
            //th2.Start();

            //======================================================

            Thread th1 = new Thread(new ThreadStart(Func1));
            Thread th2 = new Thread(new ThreadStart(Func2));

            th1.Start();
            th2.Start();

            Console.WriteLine("메인 종료");
        }
    }
}
