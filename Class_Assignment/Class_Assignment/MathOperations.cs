using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Assignment
{
    class MathOperations
    {
        // Method that outputs an integer by dividing the input by 2
        public int DivideByTwo(int num)
        {
            return num / 2;
        }

        // Method with output parameters
        public void DivideWithRemainder(int num, int divisor, out int quotient, out int remainder)
        {
            quotient = num / divisor;
            remainder = num % divisor;
        }

        // Overloaded method
        public int DivideByTwo(int num, out int remainder)
        {
            remainder = num % 2;
            return num / 2;
        }
    }
}
