using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Days
    {
        public WeekDay Day { get; set; }
    }
    public enum WeekDay
    {
        // giving values to days of the week.
        Monday = 1, // if 1 is assigned the rest should follow in order.
        Tuesday, //2
        Wednesday, //3
        Thursday, //4
        Friday,  //5
        Saturday, //6 
        Sunday  //7
    }
}
