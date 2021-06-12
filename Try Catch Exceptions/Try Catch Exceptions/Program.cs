using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Try_Catch_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age.");
            int age = Convert.ToInt32(Console.ReadLine());
            DateTime currentDate = DateTime.Now;
            DateTime yearOfBirth = currentDate.AddYears(-age);


            Console.WriteLine(yearOfBirth);
            Console.ReadLine();
        }
    }
}
