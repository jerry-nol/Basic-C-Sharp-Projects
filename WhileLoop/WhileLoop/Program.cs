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
            Console.WriteLine("Guess my favorite number");
            int winningNumber = Convert.ToInt32(Console.ReadLine());
            bool winner = winningNumber == 14;

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
