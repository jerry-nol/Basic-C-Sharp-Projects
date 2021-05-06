using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program asks questions to qualify for car insurance
            Console.WriteLine("Do you qualify for our car insurance? \nWhat is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Have you had any DUI's. Please answer \"true\" or \"false\".");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets have you had before?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // User answers must all be true
            Console.WriteLine("Qualified?");
            Console.WriteLine(age >= 15 && tickets < 3 && dui != true);

            Console.ReadLine();
        }
    }
}
