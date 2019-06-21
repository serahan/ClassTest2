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
        static void ThreadProc1()
        {
            Console.WriteLine("2번 쓰레드 {0}", Thread.CurrentThread.GetHashCode());
        }



        static void Main(string[] args)
        {
            Thread th = new Thread(new ThreadStart(ThreadProc1));
            th.Start();
            Console.WriteLine("Main 쓰레드 {0}",Thread.CurrentThread.GetHashCode());
            Console.WriteLine("Main 종료");
        }
    }
}
