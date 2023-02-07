using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Method_Assignment
{
    public class MathOperations
    {
        // Method that takes in an integer and returns the result of the math operation
        public int Operation(int number)
        {
            // Math operation for the integer
            int result = number * 2;
            return result;
        }

        // Method that takes in a decimal and returns the result of the math operation
        public int Operation(decimal decimalNumber)
        {
            // Math operation for the decimal
            int result = (int)decimalNumber / 2;
            return result;
        }

        // Method that takes in a string, converts it to an integer if possible, and returns the result of the math operation
        public int Operation(string stringNumber)
        {
            // Check if the string can be converted to an integer
            if (int.TryParse(stringNumber, out int number))
            {
                // Math operation for the integer converted from string
                int result = number / 3;
                return result;
            }
            else
            {
                Console.WriteLine("The string cannot be converted to an integer.");
                return 0;
            }
        }
    }
}
