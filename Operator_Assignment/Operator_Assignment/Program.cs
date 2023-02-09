using System;

namespace Operator_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects and assign values to their properties
            Employee emp1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };
            Employee emp2 = new Employee
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe"
            };

            // Compare the two Employee objects using the overloaded "==" operator
            if (emp1 == emp2)
            {
                Console.WriteLine("The two Employee objects are equal.");
            }
            else
            {
                Console.WriteLine("The two Employee objects are not equal.");
            }
        }
    }
}
