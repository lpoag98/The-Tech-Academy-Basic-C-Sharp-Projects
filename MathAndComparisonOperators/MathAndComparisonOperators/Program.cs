using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //int num1 = 200 / 3;
            //Console.WriteLine(num1);

            //bool TrueOrFalse = 12 > 5;
            //Console.WriteLine(TrueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 72;

            //bool isWarm = currentTemperature > roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();


            //Console.WriteLine("Input a number");
            //string num = Console.ReadLine();
            //int newnum = Convert.ToInt32(num);
            //Convert.
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = num1 * 50;
            //Console.WriteLine(num2);


            //int num3 = num1 + 25;
            //Console.WriteLine(num3);

            //float num4 = num1 / 12.5f;
            //Console.WriteLine(num4);

            //Console.WriteLine(num1 > 50);

            //Console.WriteLine(num1 % 7);

            //Console.ReadLine();


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
            Console.WriteLine("Annual salary of Person 1:" + annualsalary1);

            Console.WriteLine("Annual salary of Person 2:" + annualsalary2);


            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(annualsalary1 > annualsalary2);


            Console.ReadLine();
        }
    }
}
