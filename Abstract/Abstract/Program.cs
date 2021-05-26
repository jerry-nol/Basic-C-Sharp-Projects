using System;
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
            employee.ID = 1;
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            
            Employee employee2 = new Employee();
            employee2.ID = 1;
            employee2.FirstName = "Matt";
            employee2.LastName = "Smith";
            
            // calling SayName method 
            employee.SayName();

            Console.WriteLine(employee == employee2);

            // Object created of interface type
            //IQuittable quit = new Employee();
            
            // calling the method 
            //quit.Quit();
            
            
            Console.ReadLine();
        }
    }
}
