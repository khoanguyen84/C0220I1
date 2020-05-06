using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = { 1, 3, 5, 6, 7, 8 };
            //double[] arr2 = new double[50];
            //int[] arr3 = new int[5] { 2, 4, 6, 8, 10 };

            int size = 0;
            Console.Write("Input size of array:");
            size = int.Parse(Console.ReadLine());
            int[] arr4 = new int[size];

            //create array by manual
            //for(int i = 0; i< arr4.Length; i++)
            //{
            //    Console.Write($"A[{i+1}] = ");
            //    arr4[i] = int.Parse(Console.ReadLine());
            //}

            //create array by ramdom

            Random rnd = new Random();
            for (int i = 0; i < arr4.Length; i++)
            {
                arr4[i] = rnd.Next(10,50);
            }

            Console.WriteLine($"Print A before add");
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.WriteLine($"A[{i + 1}] = {arr4[i]}");
            }

            //item ~ arr4[i]
            //foreach (var item in arr4)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //int newItem = 0;
            //Console.Write("Input new item:");
            //newItem = int.Parse(Console.ReadLine());
            //Array.Resize(ref arr4, arr4.Length + 1);
            //arr4[arr4.Length-1] = newItem;

            //Console.WriteLine($"Print A after add");
            //for (int i = 0; i < arr4.Length; i++)
            //{
            //    Console.WriteLine($"A[{i + 1}] = {arr4[i]}");
            //}
        }
    }
}
