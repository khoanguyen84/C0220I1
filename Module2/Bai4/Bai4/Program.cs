using System;

namespace Bai4
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            Console.Write("Input your number: ");
            int number = int.Parse(Console.ReadLine());
            int* pt = &number;

            Console.WriteLine($"you entered {number}");
            Console.WriteLine($"pointer to {(int)pt} ");
            number = 15;
            Console.WriteLine($"you entered {number}");
            Console.WriteLine($"pointer to {(int)pt} ");
        }
    }
}
