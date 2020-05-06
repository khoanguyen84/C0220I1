using System;
using System.IO;

namespace MenuDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int selected = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("PHONEBOOK MANAGEMENT SYSYTEM");
                Console.WriteLine("1. Add new contact");
                Console.WriteLine("2. Update contact");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Remove contact");
                Console.WriteLine("5. Exit");

                Console.Write("Please select a number (1-5): ");
                int.TryParse(Console.ReadLine(), out selected);

                switch (selected)
                {
                    case 1:
                        {
                            Console.WriteLine("Add new contact process ..");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Update contact process ..");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Search process ..");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Rem0ve contact process ..");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Exit");
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (selected < 0 || selected > 5);
            Console.ReadKey();
        }
    }
}
