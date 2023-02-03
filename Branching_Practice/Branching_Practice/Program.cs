using System;

namespace Branching_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            decimal total = weight * width * height * length / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $" + total.ToString("0.00"));


            Console.WriteLine("Thank You!");

            Console.ReadLine(); 
        }
    }
}
