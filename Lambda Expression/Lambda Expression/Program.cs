using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
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

            foreach (Employees employee in employees)
            {
                if (employee.FirstName == "Joe")
                {

                    Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.ID);
                }
            }

            List<Employees> newList = employees.Where(x => x.FirstName == "Joe").ToList();

            Console.WriteLine(newList);

            List<Employees> ids = employees.Where(x => x.ID > 5).ToList();

            Console.WriteLine(ids);
            
            
            
            Console.ReadLine();
        }
    }
}
