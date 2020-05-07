using System;

namespace Practical1
{
    class Program
    {
        public static Shop shop = new Shop();
        static void Main(string[] args)
        {
            CreateMenu();
        }

        public static void CreateMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("PRODUCT MANAGEMENT SYSTEM");
                Console.WriteLine("Please select an option from 1 to 5:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Show Product");
                Console.WriteLine("4. Search Product");
                Console.WriteLine("5. Exit");
                Console.Write("option: ");

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
            }
            while (option > 5 || option < 1);

            Process(option);
        }

        public static void Process(int opt)
        {
            Console.Clear();
            switch (opt)
            {
                case 1:
                    {
                        AddProduct();
                        break;
                    }
                case 2:
                    {
                        RemoveProduct();
                        break;
                    }
                case 3:
                    {
                        ShowProduct();
                        break;
                    }
                case 4:
                    {
                        SearchProduct();
                        break;
                    }
                case 5:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            CreateMenu();
        }

        public static void AddProduct()
        {
            Product product = new Product();
            Console.Write("Name: ");
            product.Name = Helper.FormatName(Console.ReadLine());
            Console.Write("Description: ");
            product.Description = Console.ReadLine();
            Console.Write("Price: ");
            product.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Vote rate");
            for(int i = 0; i< product.Rate.Length; i++)
            {
                Console.Write($"Rate {i + 1} = ");
                product.Rate[i] = int.Parse(Console.ReadLine());
            }

            product.CalculateRate();

            shop.Add(product);
        }

        public static void ShowProduct()
        {
            shop.ShowProductList();
        }

        public static void RemoveProduct()
        {
            Console.Write("Enter product name: ");
            var pn = Console.ReadLine();
            shop.Remove(pn);
        }

        public static void SearchProduct()
        {
            Console.Write("Enter product name: ");
            var pn = Console.ReadLine();
            shop.Search(pn);
        }
    }
}
