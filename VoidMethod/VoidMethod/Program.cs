using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            // taking in both parameters from method
            class1.MathOp(7,7);


            
            class1.FullName(FirstName: "Banelly", LastName: "Marquez");
            
            Console.ReadLine();
        }
    }
}
