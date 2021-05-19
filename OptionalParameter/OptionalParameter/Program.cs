using System;
using System.Runtime.InteropServices;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Op op = new Op();
            Console.WriteLine("Pick a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number. Second number is optional.");

            int userInput2;
            int result;

            // If user enters second number add in parameter
            if (int.TryParse(Console.ReadLine(), out userInput2))
            {
                result = Op.Parameter(userInput, userInput2);
            }
            // if user doesn't enter second number don't include in parameter
            else
            {
                result = Op.Parameter(userInput);
            }
            
            Console.WriteLine("Numbers added = " + result);
            Console.ReadLine();
        }
    }
}
