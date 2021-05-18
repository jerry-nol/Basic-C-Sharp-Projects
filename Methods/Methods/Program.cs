using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //adding class1 method to the main program
            Class1 add = new Class1();
            Console.WriteLine("Select an integer to be added, subtracted and multiplied by different numbers.");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(add.num1 + num4);

            Class2 subtract = new Class2();
            Console.WriteLine(subtract.num2 - num4);

            Class3 multiply = new Class3();
            Console.WriteLine(multiply.num3 * num4);

            Console.ReadLine();
        }
    }
}
