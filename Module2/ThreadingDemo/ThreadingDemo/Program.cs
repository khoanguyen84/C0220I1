using System;
using System.Threading;

namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread thread1 = new Thread(Mission1);
            Thread thread2 = new Thread(Mission2);
            Console.WriteLine($"{thread1.ManagedThreadId}");
            Console.WriteLine($"{thread2.ManagedThreadId}");
            thread1.Priority = ThreadPriority.Lowest;
            thread2.Priority = ThreadPriority.Highest;
            thread1.Start();
            thread2.Start();
            thread1.Join();
            
            Console.WriteLine("Mission is completed");
            //Mission1();
            //Mission2();
        }

        public static void Mission1()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Threading 1: {i}");
            }
        }
        public static void Mission2()
        {
            for (int i = 200; i < 500; i++)
            {
                Console.WriteLine($"Threading 2: {i}");
            }
        }
    }
}
