using System;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOperations mathOperations = new MathOperations();

            // Call the first method, passing in an integer, and display the result
            int integerResult = mathOperations.Operation(5);
            Console.WriteLine("The result of the first operation is: " + integerResult);

            // Call the second method, passing in a decimal, and display the result
            int decimalResult = mathOperations.Operation(5.5M);
            Console.WriteLine("The result of the second operation is: " + decimalResult);

            // Call the third method, passing in a string that equates to an integer, and display the result
            int stringResult = mathOperations.Operation("15");
            Console.WriteLine("The result of the third operation is: " + stringResult);

            Console.ReadLine();
        }
    }
}
