using System;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks for name
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            //Asks if have ever had DUI
            Console.WriteLine("Have you ever had a DUI?");

            //boolean since its a true or false question in this example
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            //Asks for number of tickets
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTicket = Convert.ToInt32(Console.ReadLine());

            //displays qualification status
            Console.WriteLine("Qualified?");
            bool qual = age > 15 && !DUI && speedingTicket <= 3;
            Console.WriteLine(qual);



            Console.ReadLine();
        }
    }
}
