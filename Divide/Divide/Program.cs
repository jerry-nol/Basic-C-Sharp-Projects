using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide number1 = new Divide();
            Divide number2 = number1;
            number1.Amount = 334.34m;
            number2.Amount = 459.34m;

            Console.WriteLine(number2.Amount);

            Console.ReadLine();
        }
    }
}
