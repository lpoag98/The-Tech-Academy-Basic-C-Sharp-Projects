using System;
using System.Collections.Generic;


namespace CALLING_METHODS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            Console.WriteLine("Enter a number to divide each number in the list by: ");

            try
            {
                int divisor = int.Parse(Console.ReadLine());
                foreach (int number in numbers)
                {
                    int result = number / divisor;
                    Console.WriteLine(number + " divided by " + divisor + " = " + result);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input. A number was expected.");
            }

            Console.WriteLine("Program has emerged from the try/catch block and continued on with program execution.");
            Console.ReadLine();
        }
    }
}
