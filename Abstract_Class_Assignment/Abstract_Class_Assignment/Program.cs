using System;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with firstName "Sample" and lastName "Student"
            Employee employee = new Employee
            {
                firstName = "Sample",
                lastName = "Student"
            };

            // Call the "SayName" method on the employee object
            employee.SayName();

            Console.ReadLine();
        }
    }
}
