using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDemo
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[] a1;
            a1 = new int[5] { 1, 2, 3, 4, 5 };


            int[,] a2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine(a2[1, 1]);

            for(int i = 0; i < a2.GetLength(0); i++)
            {
                for(int j = 0; j < a2.GetLength(1); j++)
                {
                    Console.Write($"{a2[i,j]} ");
                }
                Console.WriteLine();
            }

            int[][] a3 = new int[3][];



        }
    }
}
