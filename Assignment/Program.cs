namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question (1, 2, 3)

            Console.WriteLine("Add: " + Maths.Add(5, 6));
            Console.WriteLine("Subtract: " + Maths.Subtract(5, 3));
            Console.WriteLine("Multiply: " + Maths.Multiply(8, 9));
            Console.WriteLine("Divide: " + Maths.Divide(50, 10));
            Console.WriteLine("Power: " + Maths.Power(2, 3));
            Console.WriteLine("Average: " + Maths.Average(  [2, 4, 6, 8 ]  ));
            Maths.ShowOperationCount();



        }
    }
}
