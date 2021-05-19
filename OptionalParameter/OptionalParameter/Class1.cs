using System;
using System.Runtime.InteropServices; // using OptionalAttribute

public class Op
{
    // Second parameter will be optional
    public static int Parameter(int j, [ Optional ] int n)
    {
        return j + n;
    }
}
