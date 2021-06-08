using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Chaining
{
    class Person
    {
        //Chaining two constructors
        // 18 will be a default age if users doesn't set one 
        public Person(string name) : this(name, 18)
        {

        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

    }

}
