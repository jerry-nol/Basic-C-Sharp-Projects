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
            // Will make the loop repeat itself until it is entered correctly.
            while(true)
            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                string currentday = Console.ReadLine();
                WeekDay day;

                // If user enter current day correctly, print to console
                if (Enum.TryParse<WeekDay>(currentday, out day))
                {
                    Console.WriteLine("Today is " + currentday);
                    Console.ReadLine();
                        // Breaks out of loop once correct date is entered.
                        break;
                }
                else
                {
                    throw new OverflowException(); // try parse failed
                }
            }
            
            catch (OverflowException)
            {
                // Throws this message day is not valid.
                Console.WriteLine("Not a valid day");
            }
            Console.ReadLine();
        }
    }
}