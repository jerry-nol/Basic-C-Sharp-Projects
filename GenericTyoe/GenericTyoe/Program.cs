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
            things.Things = new List<string>();
            
            //Adding values to List 
            things.Things.Add("Laptop");
            things.Things.Add("Notebook");
            things.Things.Add("Pen");


            //// Instantiating object with int type
            Employee<int> thing = new Employee<int>();
            thing.Things = new List<int>();
            
            // Adding values to list 
            thing.Things.Add(1);
            thing.Things.Add(2);
            thing.Things.Add(3);

            // foreach loop that will iterate through lists until it prints out all items
            foreach (string t in things.Things)
            {
                Console.WriteLine("\n"+ t);
            }

            
            
            foreach (int t in thing.Things)
            {
                Console.WriteLine("\n" + t);
            }
            Console.ReadLine();
         
        }
    }
}
