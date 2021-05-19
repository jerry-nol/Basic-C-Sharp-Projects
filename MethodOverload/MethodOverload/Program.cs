using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates object
            Operations ops = new Operations();
            
            Console.WriteLine("\n"+Operations.Overload(4,6));
            Console.WriteLine("\n" + Operations.Overload(45.34, 3.45));
            Console.WriteLine("\n" + Operations.Overload("100", "24"));
            Console.ReadLine();
        }
    }
}