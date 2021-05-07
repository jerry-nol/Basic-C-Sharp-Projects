﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program will estimate any shipping cost 
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below \n" +
                "What is the weight of your package?"
                );
            int weight = Convert.ToInt32(Console.ReadLine());
            
            // If true print right statement
            // If false print left statement
            string result = (weight <= 50 ? "What is the width?" : "Package too heavy to be shipped via Package Express. Have a good day.");
            Console.WriteLine(result);
            
            
            // Getting all the dimensions of package
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the length");
            int length = Convert.ToInt32(Console.ReadLine());

            // All must be true to ship package
            if (width <= 50 && height <= 50 && length <= 50)
            {
                // calculating cost from dimensions
                int LxWxH = length * width * height;
                int xWeight = weight * LxWxH;
                decimal total = xWeight / 100;
                Console.WriteLine("Your estimated total for shipping this package is $" + total + ".00");
            }
            else
            {
                Console.WriteLine("The package is too big to be shipped via Package Express.");
            }

            // Final message
            Console.WriteLine("Thank you.");
            Console.ReadLine();
            
        }
    }
}
