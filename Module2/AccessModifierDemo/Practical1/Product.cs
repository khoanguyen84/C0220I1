using System;
using System.Collections.Generic;
using System.Text;

namespace Practical1
{
    class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int[] Rate = new int[3];

        private double averageRate;

        public double AverateRate
        {
            get => averageRate;
        }

        public string ViewInfo()
        {
            return $"Name: {Name}\t" +
                    $"Desciption: {Description}\t" +
                    $"Price: {Price}\t" +
                    $"Average rate: {averageRate}";
        }

        public void CalculateRate()
        {
            double total = 0;
            foreach(double item in Rate)
            {
                total += item;
            }
            averageRate =  total / Rate.Length;
        }

    }
}
