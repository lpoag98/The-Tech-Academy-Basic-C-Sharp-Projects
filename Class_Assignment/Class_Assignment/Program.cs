using System;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class that includes the methods
            MathOperations operations = new MathOperations();

            // Prompt the user to enter a number
            Console.WriteLine("Enter a number: ");

            // Read the number entered by the user
            int num = int.Parse(Console.ReadLine());

            // Call the method that divides the number by 2
            operations.DivideByTwo(num);
            int result;
            operations.DivideByTwo(num, out result);
            Console.WriteLine("Result using out parameter: " + result);

            Console.ReadLine();
        }
    }
}
