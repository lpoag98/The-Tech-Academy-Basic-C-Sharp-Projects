using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Assignment
{
    interface IQuittable
    {
        void Quit();
    }

    // Employee class that implements IQuittable
    class Employee : IQuittable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implementation of Quit method
        public void Quit()
        {
            Console.WriteLine("Employee quitting.");
        }
    }
}
