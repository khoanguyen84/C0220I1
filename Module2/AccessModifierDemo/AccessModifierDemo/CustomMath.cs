using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifierDemo
{
    class CustomMath
    {
        public int Max(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }

        public int Min(int n1, int n2)
        {
            return n1 < n2 ? n1 : n2;
        }
    }
}
