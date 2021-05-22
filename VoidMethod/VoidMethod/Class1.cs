using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Class1
    {
        public void MathOp(int y, int n)
        {
            // Adding both parameters together
            Console.WriteLine(y + n);
            // Displaying just the second parameter
            Console.WriteLine(n);
        }
        // assigned parameter with name
        public void FullName(string FirstName, string LastName)
        {
            Console.WriteLine(FirstName + " " + LastName);
            
        }
    }
}
