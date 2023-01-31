using System;




class Program
{
    static void Main()
    {
        //These two lines of code display the first text the user will see.
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        
        //These lines of code display a prompt to be answered to with the readline()
        Console.WriteLine("Please input your name:");
        string name1 = Console.ReadLine();

        Console.WriteLine("What course are you on?");
        string course1 = Console.ReadLine();

        //Convert.ToInt32 converts the valuetype 
        Console.WriteLine("What page number?");
        int pagenumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Do you need help with anything, please enter true or false.");
        bool needhelp1 = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string feedback1 = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedback2 = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        int studyhours = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

        //This makes sure the program does not close at the end
        Console.ReadLine();
        
    }
}

