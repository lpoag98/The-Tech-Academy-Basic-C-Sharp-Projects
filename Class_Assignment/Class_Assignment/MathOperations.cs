using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Assignment
{
    class MathOperations
    {
        // Method that outputs an integer by dividing the input by 2
        public void DivideByTwo(int num)
        {
            int result = num / 2;
            Console.WriteLine("The result of dividing " + num + " by 2 is: " + result);
        }

        public void DivideByTwo(int num, out int result)
        {
            result = num / 2;
        }
    }
}
