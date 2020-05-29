using CoffeeManagement.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeManagement
{
    class Coffee
    {
        public static string path = @"C:\CodeGym\Class\C0220I1\C0220I1\Module2\CoffeeManagement\CoffeeManagement\Data\";
        public static string dbName = "Data.json";
        public CofffeeService CofffeeService = new CofffeeService(path, dbName);
    }
}
