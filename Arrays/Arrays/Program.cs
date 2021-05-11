using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // String of arrays
            string[] fruits = {"Apple", "Orange", "Grape", "Pineapple", "Mango"};
            
            Console.WriteLine("Choose an index from the variable fruits.");
            int fruitIndex = Convert.ToInt32(Console.ReadLine());

            // Array of integers
            int[] numbers = { 74, 1414, 96, 44, 7 };

            // List of Strings
            List<string> names = new List<string>();
            names.Add("Joseph");
            names.Add("Jimmy");
            names.Add("Kayla");
            names.Add("Derrek");
            names.Add("Ashley");



            if (fruitIndex >= 5)
            {
                Console.WriteLine("Please select a smaller index.");
            }
            else
            {
                // Prints the value of index
                Console.WriteLine(fruits[fruitIndex]);
                Console.WriteLine("Choose an index from the variable ");
                int index = Convert.ToInt32(Console.ReadLine());

                if (index >= 5)
                {
                    Console.WriteLine("Please select a smaller index.");
                }
                else
                {
                    Console.WriteLine(numbers[index]);
                    Console.WriteLine("Choose an index for the list of names");
                    int namesList = Convert.ToInt32(Console.ReadLine());

                    if (namesList >= 5)
                    {
                        Console.WriteLine("Please select a smaller index.");
                    }
                    else
                    {
                        Console.WriteLine(names[namesList]);
                    }
                }

            }
            Console.ReadLine();


            
        }
    }
}