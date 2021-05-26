using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTyoe
{
    public class Employee<T>
    {
        // list property  of things
        public List<T> Things { get; set; }
    }
}
