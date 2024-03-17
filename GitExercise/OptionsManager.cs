using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "d - Divide",
            "sabs - Subtract ABS",
            "dr - Divide Remainder",
            "ex - Exit",
            "pow - Power",
            "log - Logarithm",
            "fact - Sum of 2 factorials"
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public static void Divide(double a, double b)
        {
            Console.WriteLine($"{a} / {b} = {(a / b):f2}");
        }
        public static void SubtractABS(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {Math.Abs(a - b)}");
        }

        public static void DivideRemainder(double a , double b)
        {
            Console.WriteLine($"{a} % {b} = {a % b}");
        }

        private static long CalculateFactorial(int a)
        {
            long result = a;
            for (int i = a - 1; i >= 1 ; i--)
            {
                result *= i;
            }
            return result;
        }
        public static void Factorial(int a, int b)
        {
            Console.WriteLine($"{a}! + {b}! = {CalculateFactorial(a) + CalculateFactorial(b)}");
        }

        public static void Power(double a, double b)
        {
            Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
        }

        public static void Log(double a, double b)
        {
            Console.WriteLine($"Log of {a} with base {b} = {Math.Log(a, b)}");
        }
    }
}
