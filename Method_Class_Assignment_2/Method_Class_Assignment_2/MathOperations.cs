using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Class_Assignment_2
{
    public class MathOperations
    {
        // Method that takes two integers as parameters and performs a math operation on the first integer
        public void DoOperation(int num1, int num2)
        {
            int result = num1 * num2; // perform math operation on num1
            Console.WriteLine("The second integer is: " + num2); // display num2 to the screen
        }
    }
}
