using System;
 
namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program will compare two persons salaries
            // Person 1's info 
            Console.WriteLine("Anonymous Income Comparison Program \n" +
                "Person 1: \n" +
                "Hourly Rate");
            double hourly1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week");
            double worked1 = Convert.ToDouble(Console.ReadLine());

            // Person 2's info 
            Console.WriteLine("Person 2 \n" +
                "Hourly Rate");
            double hourly2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week");
            double worked2 = Convert.ToDouble(Console.ReadLine());

            // This calculates person 1&2's yearly salarly 
            double salary1 = hourly1 * worked1 * 52;
            double salary2 = hourly2 * worked2 * 52;

            // Printing person 1&2's salarly to console
            Console.WriteLine("Person 1 annual salary is " + salary1);
            Console.WriteLine("Person 2 annual salary is " + salary2);

            // Comparing salaries
            Console.WriteLine("Person 1 makes more money than person 2?");
            bool compare = salary1 > salary2;
            Console.WriteLine(compare);

            Console.ReadLine();
        }
    }
}
