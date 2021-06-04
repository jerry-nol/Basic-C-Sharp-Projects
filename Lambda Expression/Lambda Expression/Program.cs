using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of employees 
            List<Employees> employees = new List<Employees>();
            employees.Add(new Employees() { FirstName = "Nancy", LastName= "Jones",ID = 1 });
            employees.Add(new Employees() { FirstName = "Nick", LastName = "James", ID = 2 });
            employees.Add(new Employees() { FirstName = "Neil", LastName = "Johnson", ID = 3 });
            employees.Add(new Employees() { FirstName = "Zuly", LastName = "Davidson", ID = 4 });
            employees.Add(new Employees() { FirstName = "Bill", LastName = "Burr", ID = 5 });
            employees.Add(new Employees() { FirstName = "Tony", LastName = "Hinchcliffe", ID = 6 });
            employees.Add(new Employees() { FirstName = "Joe", LastName = "Nixon", ID = 7 });
            employees.Add(new Employees() { FirstName = "Joe", LastName = "Swanson", ID = 8 });
            employees.Add(new Employees() { FirstName = "Chester", LastName = "Winds", ID = 9 });
            employees.Add(new Employees() { FirstName = "Pax", LastName = "Fernsby", ID = 10 });

            List<Employees> newList = new List<Employees>();



            // for every employee in list
            foreach (Employees employee in employees)
            {
                // if employee first name is Joe
                if (employee.FirstName == "Joe")
                {
                    // Display employee full name and id number 
                    newList.Add(employee);
                    Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.ID);
                }
            }

            // Iterates Employee list and chooses only names that == Joe and adds them to a new list
            List<Employees> newList2 = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employees employees1 in newList2)
            {
                Console.WriteLine("\n" + employees1.FirstName + " "+ employees1.LastName);
            }

            // Iterates Employee list and chooses ID number > 5 and adds them to a new list
            List<Employees> ids = employees.Where(x => x.ID > 5).ToList();
            foreach (Employees employees2 in ids)
            {
                Console.WriteLine("\n" + employees2.FirstName + " " + employees2.LastName + " " + employees2.ID);
            }

            
            Console.ReadLine();
        }
    }
}
