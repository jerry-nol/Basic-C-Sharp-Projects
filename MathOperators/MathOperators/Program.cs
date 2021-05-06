using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // this program will multiply the users
            // input by 50 and print result to the console
            Console.WriteLine("Choose any number.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int multiply = 50;
            int value1 = number1 * multiply;
            Console.WriteLine("Your number times 50 = " + value1);

            Console.WriteLine("Choose any number.");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int addition = 25;
            int value2 = number2 + addition;
            Console.WriteLine("Your number plus 25 = " + value2);

            // This program will take a number for user
            // and compare it to 50 to see if it is greater
            // bool will put out a True or false response 
            Console.WriteLine("Choose any number.");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int greaterThan = 50;
            bool value3 = number3 > greaterThan;
            Console.WriteLine("Is your number greater than 50? " + value3);

            Console.WriteLine("Choose any number.");
            int number4 = Convert.ToInt32(Console.ReadLine());
            int  dividedBy= 7;
            // The modulus operator will divde two numbers and give the remainder as a result
            int value4 = number4 % dividedBy;
            Console.WriteLine("The remainder of your number when its divided by 7 is " + value4);
            Console.ReadLine();
        }
    }
}
