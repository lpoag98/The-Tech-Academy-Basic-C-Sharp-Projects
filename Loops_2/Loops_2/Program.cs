using System;

namespace Loops_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // This console program demonstrates while loops and do-while loops

                // This first example is a While loop.

                Console.WriteLine("Guess a number");
                int number = Convert.ToInt32(Console.ReadLine());
                
                //setting bool isGuessed is equal to number which must be the number 12.  
                bool isGuessed = number == 12;

                while (!isGuessed)
                {
                    switch (number)
                    {
                        //if case does not equal 12 then it will read "You guessed #. Try again".
                        case 62:
                            Console.WriteLine("You guessed 62. Try again.");
                            Console.WriteLine("Guess a number");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 29:
                            Console.WriteLine("You guessed 29. Try again.");
                            Console.WriteLine("Guess a number");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 55:
                            Console.WriteLine("You guessed 55. Try again.");
                            Console.WriteLine("Guess a number");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        //in case does not equal 12 then it will read false.
                        case 12:
                            Console.WriteLine("You guessed 12. That is correct!");
                            isGuessed = true;
                            break;
                        //if case does not equal any of the other previous numbers stated then it will read false..
                        default:
                            Console.WriteLine("You are wrong.");
                            Console.WriteLine("Guess a number");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }

                // This is a do-while loop. This allows the 12 to be input first try and give back the proper string "You guessed 12. That is correct!"

                Console.WriteLine("Guess a number");
                number = Convert.ToInt32(Console.ReadLine());
                isGuessed = number == 12;

                do
                {
                    switch (number)
                    {
                        case 62:
                            Console.WriteLine("You guessed 62. Try again.");
                            Console.WriteLine("Guess a number");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 29:
                            Console.WriteLine("You guessed 29. Try again.");
                            Console.WriteLine("Guess a number");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 55:
                            Console.WriteLine("You guessed 55. Try again.");
                            Console.WriteLine("Guess a number");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 12:
                            Console.WriteLine("You guessed 12. That is correct!");
                            isGuessed = true;
                            break;
                        default:
                            Console.WriteLine("You are wrong.");
                            Console.WriteLine("Guess a number");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                while (!isGuessed);

                Console.Read();
            }
        }
    }


    

