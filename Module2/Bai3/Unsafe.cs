using System;

namespace Bai3
{
    class UnsafeDemo
    {
        public unsafe static void Main(string[] args)
        {
            int n4 = 10;
            int* n5 = &n4;

            Console.WriteLine($"n4 = {n4}");
            Console.WriteLine($"size of n4 = { sizeof(int)}");
            Console.WriteLine($"n5 = {(int)n5}");
        }
    }
}