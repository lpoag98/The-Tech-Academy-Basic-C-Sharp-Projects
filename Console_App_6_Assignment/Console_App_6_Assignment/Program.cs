using System;
using System.Collections.Generic;

namespace Console_App_6_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {



            //CONSOLE APP PART ONE ASSIGNMENT

            //One-dimensional array of strings
            string[] array = { "Aaron", "Abby", "Abel", "Abigail", "Abraham" };
            Console.WriteLine("Enter some text: ");
            string input = Console.ReadLine();

            //(starting int number, array.length determines when loop stops, i++ will go onto next index in array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += input;
            }

            Console.WriteLine("Array elements after appending the user's text: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }



            //CONSOLE APP PART TWO ASSIGNMENT

            //this is the exit variable, it controls the continuation of the loop.
            bool exit = false;
            //This is where the loop is, it continues to run as long as the 
            while (!exit)
            {
                Console.WriteLine("Enter Q to quit the loop: ");
                string userChoice = Console.ReadLine();
                //if Q is entered into the readline then the if block of code will run, exit = true, and exit loop
                if (userChoice == "Q" || userChoice == "q")
                {
                    //The exit variable is only set to true when user enters upper or lowercase Q.
                    exit = true;
                }
            }
            //notifies user that loop has been exited
            Console.WriteLine("Exited the loop.");



            //CONSOLE APP PART THREE ASSIGNMENT

            // < Operator comparison
            Console.WriteLine("Loop with '<' comparison: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // <= Operator comparison
            Console.WriteLine();
            Console.WriteLine("Loop with '<=' comparison: ");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


            //CONSOLE APP PART FOUR ASSIGNMENT

            List<string> list4 = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };
            Console.WriteLine("Enter text to search in the list: ");
            string userInput = Console.ReadLine();
            int index = -1;
            bool found = false;

            //A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            for (int i = 0; i < list4.Count; i++)
            {
                if (list4[i] == userInput)
                {
                    index = i;
                    found = true;
                    //stops the loop from executing once a match has been found.
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("The text is found at index " + index);
            }
            else
            {
                Console.WriteLine("The text is not found in the list.");
            }



            //CONSOLE APP PART FIVE ASSIGNMENT

            //Two identical strings are "apple"
            List<string> list5 = new List<string> { "apple", "banana", "cherry", "apple", "date" };
            Console.WriteLine("Enter text to search in the list: ");
            string input6 = Console.ReadLine();
            List<int> indices = new List<int>();

            for (int i = 0; i < list5.Count; i++)
            {
                if (list5[i] == input6)
                {
                    indices.Add(i);
                }
            }

            if (indices.Count > 0)
            {
                Console.WriteLine("The text is found at indices: " + string.Join(", ", indices));
            }
            else
            {
                Console.WriteLine("The text is not found in the list.");
            }



            //CONSOLE APP PART SIX SUBMISSION ASSIGNMENT

            // Create a list of strings
            List<string> list6 = new List<string> { "A", "B", "C", "D", "C" };

            // Keep track of unique items
            HashSet<string> uniqueItems = new HashSet<string>();

            // Loop through the list
            foreach (string item in list6)
            {
                // Check if item is unique or a duplicate
                if (uniqueItems.Add(item))
                {
                    Console.WriteLine(item + " - this item is unique");
                }
                else
                {
                    Console.WriteLine(item + " - this item is a duplicate");
                }


                Console.ReadLine();
            }
        }
    }
}
