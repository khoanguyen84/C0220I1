using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo
{
    class FunctionDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Number 1 = ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Number 2 = ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Number 3 = ");
            int number3 = int.Parse(Console.ReadLine());
            //int sum = Sum2(number1, ref number2);
            //Console.Write($"{number1} + {number2} = {sum}");
            //Console.Write($"number1 =  {number1}, number2 = {number2}");
            //int outValue = 0;
            //int sum = Sum3(number1, number2, out int outValue);
            //Console.Write($"{number1} + {number2} = {sum}");
            //Console.Write($"number1 =  {number1}, number2 = {number2}, out value = {outValue}");

            //Swap(ref number1,ref number2);
            //Console.Write($"number1 =  {number1}, number2 = {number2}");

            int total = Sum(number1, Sum(number2, number3));
            Console.Write($"{number1} + {number2} + {number3} = {total}");
        }

        public static int Sum(int n1, int n2)
        {
            int total = 0;
            total = n1 + n2;
            return total;
        }

        public static int Sum2(int n1,ref int n2)
        {
            int total = 0;
            total = n1 + n2;
            n2 = n2 + 10;
            return total;
        }

        public static int Sum3(int n1, int n2, out int outValue)
        {
            int total = 0;
            total = n1 + n2;
            n2 = n2 + 10;
            outValue = n2;
            return total;
        }

        public static void Swap(ref int a,ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
