﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            // values to properties first and last name
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            // calling SayName method 
            employee.SayName();
            Console.ReadLine();
        }
    }
}
