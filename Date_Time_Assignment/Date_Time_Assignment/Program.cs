using System;

namespace Date_Time_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the current date and time and print it to the console
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("The current date and time is: " + currentDateTime);

            // Ask the user for a number
            Console.Write("Enter a number of hours: ");
            string input = Console.ReadLine();
            int hours;
            bool isNumeric = int.TryParse(input, out hours);

            // If the input is not a valid number, ask the user to try again
            while (!isNumeric)
            {
                Console.Write("Invalid input. Please enter a number: ");
                input = Console.ReadLine();
                isNumeric = int.TryParse(input, out hours);
            }

            // Calculate the future date and time and print it to the console
            DateTime futureDateTime = currentDateTime.AddHours(hours);
            Console.WriteLine("In " + hours + " hours, it will be: " + futureDateTime);

            // Wait for user input before exiting
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
