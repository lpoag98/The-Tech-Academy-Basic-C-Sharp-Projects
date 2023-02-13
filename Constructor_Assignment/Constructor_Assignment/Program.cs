using System;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const int num1 = 5; // Create a const variable with value 5
            var num2 = 10; // Create a variable num2 with value 10, using the 'var' keyword to let C# infer its type

            MyClass myObject = new MyClass("Hello World"); // Create a new object of MyClass and call the constructor that takes a string parameter
            Console.WriteLine(myObject.Message); // Output the message stored in the object
            Console.ReadLine();
        }
        class MyClass
        {
            public string Message { get; set; } // Declare a public property for storing the message string

            public MyClass() : this("Default Message") // Chain a default constructor to the constructor that takes a string parameter
            {
            }

            public MyClass(string message) // Constructor that takes a string parameter
            {
                Message = message; // Store the message in the object
            }
        }
    }
}

