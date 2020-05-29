using CoffeeManagement.Models;
using CoffeeManagement.Services;
using System;
using System.Collections.Generic;

namespace CoffeeManagement
{
    class Program
    {
        public static string path = @"C:\CodeGym\Class\C0220I1\C0220I1\Module2\CoffeeManagement\CoffeeManagement\Data\";
        public static string dbName = "Data.json";
        public static CofffeeService CofffeeService = new CofffeeService(path, dbName);
        static void Main(string[] args)
        {
            NewOrder();
        }

        public static void NewOrder()
        {
            Console.Write("TableId: ");
            var tableId = Console.ReadLine();
            if (CofffeeService.Check(tableId) == null)
            {
                Table table = new Table()
                {
                    cashier = "Duy",
                    endtime = "",
                    ispaid = false,
                    starttime = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"),
                    tableid = tableId,
                    orderdetails = new List<OrderDetail>()
                    {
                        new OrderDetail()
                        {
                            count = 2,
                            name = "Beer",
                            price = 20000
                        },
                        new OrderDetail()
                        {
                            count = 3,
                            name = "Coca",
                            price = 10000
                        }
                    }
                };
                CofffeeService.NewOrder(table);
                Console.WriteLine("Order success");
            }
            else
            {
                Console.WriteLine("Table is using");
            }
        }
    }
}
