using System;
using System.Collections.Generic;
using System.Text;

namespace CALLING_METHODS
{
    class MathOperations
    {
        //int name AddTen, will be used in program.cs for result, same with following method int's
        // Method that adds 10 to the input parameter
        public int AddTen(int input)
        {
            // Return the result of adding 10 to the input parameter
            return input + 10;
        }

        // Method that multiplies the input parameter by 2
        public int MultiplyByTwo(int input)
        {
            // Return the result of multiplying the input by 2
            return input * 2;
        }

        // Method that calculates the square of the input parameter
        public int Square(int input)
        {
            // Return the result of squaring the input
            return input * input;
        }
    }
}
