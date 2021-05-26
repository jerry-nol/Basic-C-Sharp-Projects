using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTyoe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating object with string type
            Employee<string> things = new Employee<string>();
            things.Things.Add("Laptop");
            things.Things.Add("Notebook");
            things.Things.Add("Pen");


            // Instantiating object with int type
            Employee<int> thing = new Employee<int>();
            thing.Things.Add(1);
            thing.Things.Add(2);
            thing.Things.Add(3);

            Console.WriteLine(thing.Things);
            Console.ReadLine();
         
        }
    }
}
