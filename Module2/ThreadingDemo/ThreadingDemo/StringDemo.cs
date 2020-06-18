using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadingDemo
{
    class StringDemo
    {
        public static void Main()
        {
            string str = "C0220i1";
            StringBuilder sb = new StringBuilder(str);
            sb[5] = 'I';
            string a = string.Empty; // "";
            string.IsNullOrEmpty(a);
            string.IsNullOrWhiteSpace(a);
            int[] arr = { 1, 2, 3, 4, 5 };
            string.Join("-", arr);
        }
    }
}
