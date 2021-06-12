using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Chaining
{
    class Program
    {
        static void Main(string[] args)
        {
            // constant variable
            const string name = "Peter";
            // using "var" to create a variable
            var newPerson = new Person("Frank");

            Console.WriteLine("{0} is {1} years old", newPerson.Name, newPerson.Age);
            Console.WriteLine("\n"+name);
            Console.ReadLine();
        }
    }
}
