using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext("StudentDatabase"))
            {
                context.Seed();
                Console.WriteLine("Student added to database.");
            }

            Console.ReadLine();
        }

    }
}
