using System;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperation class
            MathOperation mathOp = new MathOperation();

            // Ask user to input first number
            Console.WriteLine("Enter first number: ");

            // Converting the user's input from string to int
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Ask user to input second number (optional)
            Console.WriteLine("Enter second number (optional): ");
            string input = Console.ReadLine();
            int num2 = 0;

            int result = 0;
            // Checking if the user entered something for the second number
            if (string.IsNullOrEmpty(input))
            {
                // If the second number was not entered, calling the DoMath method with one parameter (num1 * num1)
                result = mathOp.DoMath(num1);
            }
            else
            {
                num2 = Convert.ToInt32(input);
                // If the second number was entered, calling the DoMath method with two parameters
                result = mathOp.DoMath(num1, num2);
            }

            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }
    }
}
