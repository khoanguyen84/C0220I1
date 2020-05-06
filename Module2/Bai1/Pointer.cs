using System;
namespace Bai1
{
    class Pointer
    {
        public unsafe static void Main(string[] args)
        {
            Console.Write("Input your number:");
            int number = int.Parse(Console.ReadLine());
            int* p = &number;
            Console.WriteLine(number);
            Console.WriteLine((int)p);
        }
    }

}