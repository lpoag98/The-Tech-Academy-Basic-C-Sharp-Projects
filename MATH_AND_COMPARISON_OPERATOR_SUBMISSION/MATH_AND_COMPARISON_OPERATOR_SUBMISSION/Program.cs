using System;

namespace MATH_AND_COMPARISON_OPERATOR_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");


            Console.WriteLine("Person 1");


            Console.WriteLine("Hourly Rate?");
            int hourlyrate1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int hourperweek1 = Convert.ToInt32(Console.ReadLine());

            int annualsalary1 = hourlyrate1 * hourperweek1 * 52;

            Console.WriteLine("Person 2");


            Console.WriteLine("Hourly Rate?");
            int hourlyrate2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int hourperweek2 = Convert.ToInt32(Console.ReadLine());

            int annualsalary2 = hourlyrate2 * hourperweek2 * 52;

            //Annual salary of person 1 and 2
            Console.WriteLine("Annual salary of Person 1: " + annualsalary1);

            Console.WriteLine("Annual salary of Person 2: " + annualsalary2);


            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(annualsalary1 > annualsalary2);


            Console.ReadLine();
        }
    }
}
