using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Objects_Assignment
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // SayName method to write full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    // Employee class that inherits from Person class and has Id property
    class Employee : Person
    {
        public int Id { get; set; }
    }
}
