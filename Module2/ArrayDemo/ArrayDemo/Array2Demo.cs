using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace ArrayDemo
{
    class Array2Demo
    {
        static void Main(string[] args)
        {
            //C1
            //int[,] m1 = new int[2, 3];
            //int[,] m2 = new int[2, 3] { { 3,3,3}, { 4,4,4} };
            //int col, row;
            //Console.Write("Input row: ");
            //row = int.Parse(Console.ReadLine());
            //Console.Write("Input col: ");
            //col = int.Parse(Console.ReadLine());

            //int[,] m3 = new int[row, col];
            //Random rnd = new Random();
            //for(int i = 0; i< row; i++)
            //for(int i = 0; i< m3.GetLength(0); i++)
            //{
            //    //for(int j=0; j<col; j++)
            //    for(int j = 0; j < m3.GetLength(1); j++)
            //    {
            //        m3[i, j] = rnd.Next(10, 50);
            //    }
            //}

            //for (int i = 0; i < m3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m3.GetLength(1); j++)
            //    {
            //        Console.Write($"{m3[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}


            //C2
            int col1, row1;
            Console.Write("Input row: ");
            row1 = int.Parse(Console.ReadLine());
            Console.Write("Input col: ");
            col1 = int.Parse(Console.ReadLine());
            int[][] m4 = new int[row1][];
            Random rnd = new Random();
            for (int i = 0; i < row1; i++)
            {
                int[] a1 = new int[col1];
                for (int j = 0; j < col1; j++)
                {
                    a1[j] = rnd.Next(10, 50);
                }
                m4[i] = a1;
            }
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.Write($"{m4[i][j]} ");
                }
                Console.WriteLine();

            }
        }
    }
}
