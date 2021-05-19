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
            //creating object
            Operations ops = new Operations();
            ops = Overload(3, 5);
            
            Console.WriteLine(ops);
            Console.ReadLine();
        }
    }
}