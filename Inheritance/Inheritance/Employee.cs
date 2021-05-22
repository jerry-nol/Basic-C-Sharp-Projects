using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Inheritating Person class to Employee class 
    class Employee : Person
    {
        // Giving an int ID property to this class only
        public int ID { get; set; }
    }
}
