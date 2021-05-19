using System;
using System.Runtime.InteropServices;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Op op = new Op();
            int og = Op.Parameter(5,9);
            Console.WriteLine("Your number added ="+ og);           
            
            Console.ReadLine();
        }
    }
}
