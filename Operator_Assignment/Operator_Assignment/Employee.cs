using System;
using System.Collections.Generic;
using System.Text;

namespace Operator_Assignment
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the "==" operator to compare two Employee objects by their Id property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null or both are the same instance, return true
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // If one is null and the other is not, return false
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return false;
            }

            // Compare the Id properties of the two Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator to compare two Employee objects by their Id property
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
    }
}
