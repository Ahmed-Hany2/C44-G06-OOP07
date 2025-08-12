using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Maths
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero isnot valid");
                return double.NaN;
            }
            return a / b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Average(double[] numbers)
        {
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }
    }
}
