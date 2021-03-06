using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My favorite number could be any of these options.");
            int between = 1;
            while (between < 21)
            {
                Console.WriteLine(between);
                between++;
            }
            
            Console.WriteLine("Guess my favorite number");
            int winningNumber = Convert.ToInt32(Console.ReadLine());
            bool winner = winningNumber == 14;

            // do while loop will keep the program running
            // until the correct number is guessed
            do
            {
                switch (winningNumber)
                {
                    case 13:
                        Console.WriteLine("So close... Try again.");
                        Console.WriteLine("Guess my favorite number");
                        winningNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 15:
                        Console.WriteLine("So close... Try again.");
                        Console.WriteLine("Guess my favorite number");
                        winningNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 14:
                        Console.WriteLine("You are the lucky winner of $100.00.");
                        // This will stop the program once it is guessed
                        winner = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect. Please try again.");
                        Console.WriteLine("Guess my favorite number");
                        winningNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!winner);
            Console.Read();

        }
    }
}
