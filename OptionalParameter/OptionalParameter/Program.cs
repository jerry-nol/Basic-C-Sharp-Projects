using System;
using System.Runtime.InteropServices;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Op op = new Op();
           
            // You can enter either one or two parameters
            // The second parameter is optional
            int sum = Op.Parameter(5);
            
            Console.WriteLine("Your number added =" + sum);
            Console.ReadLine();
        }
    }
}
