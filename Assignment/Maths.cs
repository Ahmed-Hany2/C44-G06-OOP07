using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Maths
    {
        private static int operationCount = 0;
        public static double Add(double a, double b)
        {
            operationCount++;
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            operationCount++;
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            operationCount++;
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            operationCount++;
            if (b == 0)
            {
                Console.WriteLine("Division by zero isnot valid");
                return double.NaN;
            }
            return a / b;
        }

        public static double Power(double a, double b)
        {
            operationCount++;
            return Math.Pow(a, b);
        }

        public static double Average(double[] numbers)
        {
            operationCount++;
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }

        public static void ShowOperationCount()
        {
            Console.WriteLine($"Total operations performed: {operationCount}");
        }
    }
}
