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
        static void Func()
        {
            int i = 0;
            while(true)
            {
                Console.WriteLine("{0} ",i++);
                Thread.Sleep(300);
            }
        }

        
        static void Main(string[] args)
        {
            Thread th = new Thread(new ThreadStart(Func));
            th.IsBackground = true; // 쓰레드 돌아가는거 정지
            th.Start();
            Console.WriteLine("Main 종료");
        }
    }
}
