using System;

namespace Methods_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object and initialize its properties
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 12345;

            // Call SayName method on the Employee object
            employee.SayName();

            Console.ReadLine();
        }
    }
}
