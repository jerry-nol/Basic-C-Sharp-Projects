using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 20, 30 };
            Console.WriteLine("Enter a number to divide all numbers in numbers list");

            try
            {
                int dividedBy = Convert.ToInt32(Console.ReadLine());
                // for every number in list it will get 
                // divided by any number the user enters.
                foreach (int num in numbers)
                {
                    int total = num / dividedBy;
                    Console.WriteLine("\n" + total);
                }
            }
            // if user enters a string this message will display
            catch (FormatException ex)
            {
                Console.WriteLine("Please only enter a whole number.");
                return;
            }
            // If user enters 0 this message will display
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can not divide by zero");
                return;
            }
            // Any other possible error this message will display
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("The program has now exited the try/catch block and will continue on.");
            Console.ReadLine();
        }
    }
}
