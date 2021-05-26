using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Employee : Person//, //IQuittable
    {
        public int ID { get; set; }
        // implementing method from Person class
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public static bool operator== (Employee employee, Employee employee2)
        {
            // return true if id's are equal
            return employee.ID == employee2.ID;
        }
        public static bool operator!= (Employee employee, Employee employee2)
        {
            // returns false if id's are not equal 
            return employee.ID != employee2.ID;
        }


        //public void Quit()
        //{
        //Console.WriteLine("\nThis program will close after you press enter.");
        //}
    }
}
