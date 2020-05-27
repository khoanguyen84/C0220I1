using System;
using System.Threading;
namespace SearchDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Thread thread1 = new Thread(Thread1);
            //Thread thread2 = new Thread(Thread2);
            //thread2.Start();
            //thread1.Start();

            //Console.WriteLine($"{n}! =\t\t {GiaiThua2(n)}");

            //Console.WriteLine($"Max long value = {long.MaxValue}");
            int n = 200000;
            var startTime1 = DateTimeOffset.Now;
            Show(n);
            var endTime1 = DateTimeOffset.Now;
            Console.WriteLine($"Total time = {(endTime1 - startTime1).TotalSeconds}");
            //Show(n);

        }

        public static void Thread1()
        {
            long n = 20;
            var startTime1 = DateTimeOffset.Now;
            Console.WriteLine($"{n}! =\t\t {GiaiThua2(n)}");
            var endTime1 = DateTimeOffset.Now;
            Console.WriteLine($"Total time = {(endTime1 - startTime1).TotalSeconds}");
        }

        public static void Thread2()
        {
            long n = 20;
            var startTime = DateTimeOffset.Now;
            Console.WriteLine($"{n}! =\t\t {GiaiThua(n)}");
            var endTime = DateTimeOffset.Now;
            Console.WriteLine($"Total time = {(endTime - startTime).TotalSeconds}");
        }

        public static long GiaiThua(long n)
        {
            if (n < 2)
            {
                return 1;
            }
            return GiaiThua(n - 1) * n;
        }

        public static long GiaiThua2(long n)
        {
            long total = 1;
            for(long i=1; i<=n; i++)
            {
                total *= i;
            }

            return total;
        }

        public static void Show(int n)
        {
            if(n == 1)
            {
                Console.WriteLine($"{n}");
                return;
            }
            else if(n > 1)
            {
                Show(n - 1);
            }
            
        }

        public static void Show2(int n)
        {
            for(int i=0; i< n; i++)
            {
                Console.WriteLine($"{i}");
            }
        }

    }
}

