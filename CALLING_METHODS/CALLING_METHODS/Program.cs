using System;
using System.Collections.Generic;


namespace CALLING_METHODS
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks user for a number and stores it as userInput
            Console.WriteLine("Enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //3 int results made to take input and applies the method accordingly 
            MathOperations math = new MathOperations();
            int result1 = math.AddTen(userInput);
            int result2 = math.MultiplyByTwo(userInput);
            int result3 = math.Square(userInput);


            //displays to the user the results.
            Console.WriteLine("Result 1: " + result1);
            Console.WriteLine("Result 2: " + result2);
            Console.WriteLine("Result 3: " + result3);

            Console.ReadLine();
        }
    }
}
