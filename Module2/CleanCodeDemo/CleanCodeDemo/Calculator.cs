using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeDemo
{
    public static class Calculator
    {
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int Multiple(int n1, int n2)
        {
            return n1 * n2;
        }
        public static int Division(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
