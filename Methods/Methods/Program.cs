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
            
            // Printing off all functions 
            Console.WriteLine("\n"+ Class1.Add(4,num4));
            Console.WriteLine("\n" + Class1.Subtract(9,num4));
            Console.WriteLine("\n" + Class1.Multiply(50,num4));
            

            Console.ReadLine();
        }
    }
}
