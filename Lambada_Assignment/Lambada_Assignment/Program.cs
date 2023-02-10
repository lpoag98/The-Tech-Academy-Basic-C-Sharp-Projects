using System;
using System.Collections.Generic;

namespace Lambada_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of 10 employees
            List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, FirstName = "John", LastName = "Doe" },
            new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
            new Employee { Id = 3, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 4, FirstName = "Jim", LastName = "Brown" },
            new Employee { Id = 5, FirstName = "Jane", LastName = "Smith" },
            new Employee { Id = 6, FirstName = "Joe", LastName = "Doe" },
            new Employee { Id = 7, FirstName = "Jill", LastName = "Johnson" },
            new Employee { Id = 8, FirstName = "Jack", LastName = "Brown" },
            new Employee { Id = 9, FirstName = "Janet", LastName = "Smith" },
            new Employee { Id = 10, FirstName = "Jim", LastName = "Johnson" }
        };

            // Use a foreach loop to create a new list of employees with the first name "Joe"
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            // Use a lambda expression to create a new list of employees with the first name "Joe"
            List<Employee> joesLambda = employees.FindAll(e => e.FirstName == "Joe");

            // Use a lambda expression to create a new list of employees with an Id number greater than 5
            List<Employee> idGreaterThan5 = employees.FindAll(e => e.Id > 5);

            Console.ReadLine();
        }
    }
}
