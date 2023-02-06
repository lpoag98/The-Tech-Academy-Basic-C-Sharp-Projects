using System;
using System.Collections.Generic;

namespace Console_App_Strings_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 10, 20, 30, 40, 50 };

            Console.WriteLine("Pick a number to divide each number in the list by: ");

            //This is the try of the try-catch
            try
            {
                int divisor = int.Parse(Console.ReadLine());
                foreach (int number in intList)
                {
                    int result = number / divisor;
                    Console.WriteLine(number + " divided by " + divisor + " = " + result);
                }

            //the catch block will catch any errors specified in the curly brackests
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input. A number was expected.");
            }

            //always performed no matter what
            finally
            {
                Console.ReadLine();
            }

            Console.WriteLine("Program has emerged from the try/catch block and continued on with program execution.");
            Console.ReadLine();
        }
    }
}
