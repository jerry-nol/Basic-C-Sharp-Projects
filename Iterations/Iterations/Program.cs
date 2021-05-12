using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[3];
            Console.WriteLine("Please enter your top 3 favorite fruits.");

            for (int i = 0; i < fruits.Length; i++)
            {
                // User's input will be added to the end for fruits array
                fruits[i] = Console.In.ReadLine();
            }
            
            // Deleting "i++" from for loop will create an infinite loop
            // adding "i++" will fix infinite loop
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.Write(fruits[i] + " ");
            }

            int h = 0;
            
            // display message if "h" is less than 3
             if (h < 3)
            {
                Console.WriteLine("\nh is less than 3");
            }
            int k = 3;

            if (k <= 3)
            {
                Console.WriteLine("k is less than or equal to 3");
            }

            List<string> students = new List<string>() { "James", "Colby", "Maddison", "Alice", "Matt" };
            Console.WriteLine("Search for student in the class.");
            string search = Console.ReadLine();            
            
            // If user input correct student it will display
            if (students.Contains(search))
            {
                Console.WriteLine(search + " is in the class.");
            }
            // if is user inputs incorrect student
             else
            {
                Console.WriteLine(search + " was not found");
            }

            List<string> animals = new List<string>() { "dog", "horse", "horse", "donkey", "horse" , "lion"};
            Console.WriteLine("Enter a type of animal");
            string animal = Console.ReadLine();
            int count = 0;
            foreach(string item in animals)
            {
                // if item is == 0 it will get displayed
                if (animal == item && count == 0)
                {
                    Console.WriteLine("\n" + item);
                    count++;
                }
                // if item is on list more than once counter will add one and display this message.
                else if (animal == item && count > 0)
                {
                    Console.WriteLine("\n" + item + " is on the list more than once");
                }
                else 
                {
                    Console.WriteLine("\n" + item);
                }
            }
            // is animal is not on the list it will tell the user at the end of the list of items
            if (count == 0)
            {
                Console.WriteLine("\n\nThis animal is not on the list");
            }
  
            Console.ReadLine();

        }
    }
}
