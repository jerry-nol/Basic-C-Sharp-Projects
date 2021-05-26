using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTyoe
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }

        public void Add()
        {
            Console.WriteLine(Things);
        }
    }
}
