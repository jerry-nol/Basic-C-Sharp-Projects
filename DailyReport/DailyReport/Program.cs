using System;


namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program will ask a few question about a students studies
            Console.WriteLine("The Tech Academy.\n" +
                "Student Daily Report\n" +
                "1) What is your full name?");
            string fullName = Console.ReadLine();
            
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            
            Console.WriteLine("What page number are you on?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer \"Yes\" or \"No\" ");
            string TorF = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();

            Console.WriteLine("Is there any feedback you would like to give? Please be specific if yes.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An instructor will contact \n" +
                "you shortly. Have a great day!");
            Console.Read();
        }
    }
}
