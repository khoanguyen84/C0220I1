using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifierDemo
{
    static class MyMath
    {
        public static double PI = 3.14;
        public static int Max(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }

        public static int Min(int n1, int n2)
        {
            return n1 < n2 ? n1 : n2;
        }
    }
}
