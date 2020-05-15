using System;
using System.ComponentModel;
using System.Globalization;

namespace CleanCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number 1 = ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("number 2 = ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{number1} + {number2} = {Calculator.Add(number1, number2)}");
            Console.WriteLine($"{number1} - {number2} = {Calculator.Subtract(number1, number2)}");
            Console.WriteLine($"{number1} x {number2} = {Calculator.Multiple(number1, number2)}");
            Console.WriteLine($"{number1} : {number2} = {Calculator.Division(number1, number2)}");


            Console.WriteLine($"{number1} + {number2} = " +
                $"{CalculatorUpgrade.Calculator2(number1, number2, Helper.Operand.OperandAdditional)}");
            Console.WriteLine($"{number1} - {number2} = " +
                $"{CalculatorUpgrade.Calculator2(number1, number2, Helper.Operand.OperandSubtract)}");
            Console.WriteLine($"{number1} x {number2} = {Calculator.Multiple(number1, number2)}");
            Console.WriteLine($"{number1} : {number2} = {Calculator.Division(number1, number2)}");
        }
    }
}
