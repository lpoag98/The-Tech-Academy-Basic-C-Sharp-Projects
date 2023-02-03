using System;

namespace Loops_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 62:
                    Console.WriteLine("You guessed 62. Try again.");
                    break;
                

            }

            Console.Read();
        }
    }
}
