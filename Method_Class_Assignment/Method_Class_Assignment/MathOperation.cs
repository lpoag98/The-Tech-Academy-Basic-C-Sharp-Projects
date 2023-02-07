using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Class_Assignment
{
    class MathOperation
    {
        // Method that takes two integers as parameters and performs a math operation on the first integer, then displays the second integer to the screen
        public void DoMath(int firstInt, int secondInt)
        {
            int result = firstInt + 10;
            Console.WriteLine("Result: " + result);
            Console.WriteLine("Second Integer: " + secondInt);
        }
    }
}
