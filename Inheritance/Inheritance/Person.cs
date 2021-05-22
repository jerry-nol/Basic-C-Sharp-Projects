using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        // Two properties of persons name
        public string FirstName{ get; set; }
        public string LastName { get; set; }

        // When method is called it will display properties given 
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
