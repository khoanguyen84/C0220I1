using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeManagement.Models
{
    class Table
    {
        public string tableid { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
        public string cashier { get; set; }
        public bool ispaid { get; set; }
        public double totalamount => CalculatorTotal();
        public List<OrderDetail> orderdetails { get; set; }

        public override string ToString()
        {
            string str = "";
            str = $"\n{str}{tableid}\t{cashier}\t{starttime}\t{endtime}\t{totalamount}";
            foreach(var od in orderdetails)
            {
                str = $"{str}\n{od.ToString()}";
            }
            return str;
        }

        public double CalculatorTotal()
        {
            double total = 0;
            foreach(var od in orderdetails)
            {
                total += od.amount;
            }
            return total;
        }
    }
}
