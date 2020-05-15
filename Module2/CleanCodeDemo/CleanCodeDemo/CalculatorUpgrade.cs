using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeDemo
{
    static class CalculatorUpgrade
    {
        public static int Calculator(int number1, int number2, char operand)
        {
            if (operand == Operand.OperandAdditional)
            {
                return number1 + number2;
            }
            if (operand == Operand.OperandSubtract)
            {
                return number1 - number2;
            }
            if (operand == Operand.OperandMultiple)
            {
                return number1 * number2;
            }
            if (operand == Operand.OperandDevison)
            {
                return number1 / number2;
            }
            return -1;
        }

        public static int Calculator2(int number1, int number2, char operand)
        {
            int result = 0;
            switch (operand)
            {
                case Helper.Operand.OperandAdditional:
                //case (char)EOperand.OperandAdditional :
                //case Helper.SOperand.OperandAdditional:
                    {
                        result = number1 + number2;
                        break;
                    }
                case Operand.OperandSubtract:
                    {
                        result = number1 - number2;
                        break;
                    }
                case Operand.OperandMultiple:
                    {
                        result = number1 * number2;
                        break;
                    }
                case Operand.OperandDevison:
                    {
                        result = number1 / number2;
                        break;
                    }
            }
            return result;
        }
    }
}
