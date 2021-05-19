using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Operations
{
    //method 1 multiplying to integers
    public static int Overload(int z, int r)
    {
        return z * r;
    }
    // method 2 adding two decimal numbers.
    public static double Overload(double n, double d)
    {
        return n + d;
    }
    // method 3 adding two strings for an integer outcome 
    public static int Overload(string m, string f)
    {
        int u = int.Parse(m);
        int h = int.Parse(f);
        return u + h;
    }
}
