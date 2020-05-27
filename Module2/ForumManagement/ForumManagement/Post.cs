using System;
using System.Collections.Generic;
using System.Text;

namespace ForumManagement
{
    class Post : IPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        private double AverageRate => CalculatorRate();
        public List<int> Rates = new List<int>();

        public double CalculatorRate()
        {
            double total = 0.0;
            if(Rates.Count > 0)
            {
                foreach (var rate in Rates)
                {
                    total += (double)rate;
                }
                return total / Rates.Count;
            }
            return total;
        }

        public string Display()
        {
            return $"Id: {Id}\t" +
                $"Title: {Title}\t" +
                $"Content: {Content}\t" +
                $"Author: {Author}\t" +
                $"Count: {Rates.Count}\t" +
                $"Average rate: {AverageRate}";
        }
    }
}
