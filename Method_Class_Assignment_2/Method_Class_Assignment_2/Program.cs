using System;

namespace Method_Class_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOp = new MathOperations(); // instantiate the class

            mathOp.DoOperation(5, 10); // call the method and pass in two numbers
            mathOp.DoOperation(num2: 20, num1: 5); // call the method and specify the parameters by name

            Console.ReadLine();
        }
    }
}
