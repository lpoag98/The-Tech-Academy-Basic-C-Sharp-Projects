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
            int result = operations.DivideByTwo(num);

            // Display the result to the screen
            Console.WriteLine("The result is: " + result);

            // Call the method with output parameters
            int quotient, remainder;
            operations.DivideWithRemainder(num, 2, out quotient, out remainder);

            // Display the result to the screen
            Console.WriteLine("Quotient: " + quotient + ", Remainder: " + remainder);

            // Call the overloaded method
            result = operations.DivideByTwo(num, out remainder);

            // Display the result to the screen
            Console.WriteLine("Result: " + result + ", Remainder: " + remainder);
        }
    }
}
