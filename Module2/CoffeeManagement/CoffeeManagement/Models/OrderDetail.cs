using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace CoffeeManagement.Models
{
    class OrderDetail
    {
        public string name { get; set; }
        public int count { get; set; }
        public int price { get; set; }
        public double amount => CalculatorAmount();

        public override string ToString()
        {
            return $"\t{name}\t{count}\t{price}\t{amount}";
        }

        public double CalculatorAmount()
        {
            return (double)count * (double)price;
        }
    }
}
