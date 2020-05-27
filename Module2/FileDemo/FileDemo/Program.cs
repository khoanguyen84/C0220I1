using System;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\CodeGym\Class\C0220I1\C0220I1\Module2\FileDemo\FileDemo\Data\Input";
            string fileName = "input.txt";
            //Directory.CreateDirectory(path);
            //Directory.Delete(path);
            //using (StreamWriter sw = File.AppendText($@"{path}\{fileName}"))
            //{
            //    sw.WriteLine("CodeGym");
            //    sw.WriteLine("C0220");
            //    sw.WriteLine("Hello world");
            //}

            int[,] matrix;
            int row = 0, col = 0;
            using (StreamReader sr = File.OpenText($@"{path}\{fileName}"))
            {
                string line = sr.ReadLine();
                string[] rowcol = line.Split(" ");
                row = int.Parse(rowcol[0]);
                col = int.Parse(rowcol[1]);
                matrix = new int[row, col];
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] rows = line.Split(" ");
                    
                    for (int j = 0; j < rows.Length; j++)
                    {
                        matrix[i, j] = int.Parse(rows[j]);
                    }
                    i++;
                    
                }
            }

            string outfile = "output.txt";
            using (StreamWriter sw = File.CreateText(($@"{path}\{outfile}")))
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        sw.Write($"{matrix[i, j]*2} ");
                    }
                    sw.WriteLine();
                }
            }
                
            //string path = @"C:\CodeGym\Class\C0220I1\C0220I1\Module2\FileDemo\FileDemo\Data\Log";
            //string fileName = $"log_{DateTime.Now.ToString("ddMMyyyyhh")}.txt";
            //Directory.CreateDirectory(path);;
            //try
            //{
            //    int a = 6;
            //    int b = 0;
            //    Console.WriteLine(a / b);
            //}
            //catch(Exception e)
            //{
            //    using (StreamWriter sw = File.AppendText($@"{path}\{fileName}"))
            //    {
            //        sw.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}: {e.Message}");
            //    }
            //}
        }
    }
}

