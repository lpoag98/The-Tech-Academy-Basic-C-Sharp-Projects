using System;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOp = new MathOperation();

            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Call method by passing two numbers as arguments
            mathOp.DoMath(num1, num2);

            // Call method by specifying parameters by name
            mathOp.DoMath(secondInt: num2, firstInt: num1);

            Console.ReadLine();
        }
    }
}
