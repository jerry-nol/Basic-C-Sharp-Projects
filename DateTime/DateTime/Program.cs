using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the current time.
            DateTime currentTime = DateTime.Now;
            
            Console.WriteLine("The current date and time right now is: \n" + currentTime
                + "\n\nChoose the hours you would like to add.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            
            // Adding the users hours to the current time
            DateTime hoursLater = currentTime.AddHours(userInput);
            
            Console.WriteLine(string.Format("\n{0}", hoursLater));
            Console.ReadLine();
        }
    }
}
