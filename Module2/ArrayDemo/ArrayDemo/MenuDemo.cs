using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo
{
    class MenuDemo
    {
        static void Main(string[] args)
        {
            Process();
        }

        public static void CreateMenu(out int selected)
        {
            do
            {
                Console.WriteLine("PHONE MANAGEMENT SYSTEM");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Remove");
                Console.WriteLine("4. Contain");
                Console.WriteLine("5. Exit");
                Console.Write("Please select an option (1-5): ");
                int.TryParse(Console.ReadLine(), out selected);
                if(selected < 1 || selected > 5)
                {
                    Console.Clear();
                }
            }
            while (selected < 1 || selected > 5);

        }

        public static void Process()
        {
            int selected = 0;
            do
            {
                CreateMenu(out selected);
                switch (selected)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Add processing");
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Update processing");
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Remove processing");
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Contain processing");
                            break;
                        }
                    case 5:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (selected != 5);
        }
    }
}
