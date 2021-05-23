using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Employee : Person
    {
        // implementing method from Person class
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
