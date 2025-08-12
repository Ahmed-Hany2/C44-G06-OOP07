namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question (1)
            Maths maths = new Maths();

            Console.WriteLine("Add: " + maths.Add(5, 6));
            Console.WriteLine("Subtract: " + maths.Subtract(5, 3));
            Console.WriteLine("Multiply: " + maths.Multiply(8, 9));
            Console.WriteLine("Divide: " + maths.Divide(50, 10));
            Console.WriteLine("Power: " + maths.Power(2, 3));
            Console.WriteLine("Average: " + maths.Average(  [2, 4, 6, 8 ]  ));



        }
    }
}
