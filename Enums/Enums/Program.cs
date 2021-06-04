using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Repeats the loop until entered correctly
            while(true)
            try
            {
                Console.WriteLine("Please enter the current day of the week.");

                string userInput = Console.ReadLine();

                // Takes user input and compares to enum list and assigns variable day 
                WeekDay day = (WeekDay)Enum.Parse(typeof(WeekDay), userInput);

                Console.WriteLine("Today is " + day);
                Console.ReadLine();
                    // Breaks out of loop once day is entered correctly.
                    break;
            }
            catch (ArgumentException)
            {
                 // Throws this message day is not valid.
                 Console.WriteLine("Not a valid day");
            }
            Console.ReadLine();
        }
    }
}