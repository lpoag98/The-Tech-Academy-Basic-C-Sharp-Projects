using System;

namespace Parsing_Enums_Assignment
{
    class Program
    {
        
        // Enum for days of the week
        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Enter the current day of the week:");
            string input = Console.ReadLine();

            // Try to parse the user's input as a day of the week
            try
            {
                // Assign the value to a variable of the enum data type
                DaysOfWeek today = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), input);
                Console.WriteLine("Today is: " + today);
            }
            catch (Exception)
            {
                // Print error message if input is not a valid day of the week
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
    }
}
