using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeDemo
{
    static class Helper
    {
        public static class Operand
        {
            public const char OperandAdditional = '+';
            public const char OperandSubtract = '-';
            public const char OperandMultiple = 'x';
            public const char OperandDevison = ':';
        }
        public enum EOperand
        {
            OperandAdditional = '+',
            OperandSubtract = '-',
            OperandMultiple = 'x',
            OperandDevison = '/'
        }

        public struct SOperand
        {
            public const char OperandAdditional = '+';
            public const char OperandSubtract = '-';
            public const char OperandMultiple = 'x';
            public const char OperandDevison = ':';

            public void Show()
            {

            }
        }

        public static int Find(int[] arr, int value)
        {
            int pos = -1;
            for(int i=0; i< arr.Length; i++)
            {
                if(arr[i] == value)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
        public static int FindAd(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool IsPrime(int number)
        {
            int total = 0;
            for(int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    total += 1;
                }
            }
            if(total == 2)
            {
                return true;
            }
            return false;
        }
        public static bool IsPrime2(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return number >= 2 && true;
        }
    }
}
