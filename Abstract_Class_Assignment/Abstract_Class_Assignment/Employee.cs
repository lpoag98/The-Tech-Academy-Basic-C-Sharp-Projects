using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Assignment
{
    public class Employee : Person
    {
        // Implementation of the abstract method "SayName"
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
