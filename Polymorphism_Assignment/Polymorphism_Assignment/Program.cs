using System;

namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type Employee
            Employee employee = new Employee();

            // Assign FirstName and LastName properties
            employee.FirstName = "John";
            employee.LastName = "Doe";

            // Create an object of type IQuittable and assign the employee object to it
            IQuittable quittable = employee;

            // Call the Quit method on the IQuittable object
            quittable.Quit();

            Console.ReadLine();
        }
    }
}
