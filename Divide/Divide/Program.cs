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
            Divide divide = new Divide();
            Console.WriteLine("Pick a number to get divided by 2");
            int any = Convert.ToInt32(Console.ReadLine());
            int result = any / 2;
            Console.WriteLine("\nThe number " + any + " divided by 2 = " + result);
            
            // Declaring variable without setting it a value
            int O;
            // Passing variable O int passed in with "out" keyword
            Divide.ByTwo(out O);
            Console.WriteLine("\nInteger L divided by 2 = " + O);

            Console.ReadLine();
        }
    }
}
