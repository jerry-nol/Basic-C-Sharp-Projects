using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide
{
    class Divide
    {
        public void ByTwo(int any)
        {
            Console.WriteLine(any);
        }
        public static void ByTwo(out int L)
        {
            // Assigning the value to integer L
            // Then divided by the number 2
            L = 30;
            L /= 2;
        }
    }
}
