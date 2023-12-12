using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Solution
{
    public static long FindNextSquare(long num)
    {
        long rt = (long)Math.Sqrt(num);
        if (rt * rt == num) return (rt + 1) * (rt + 1);
        return -1;
    }

    public static void Main(string[] args)
    {
        long test1 = FindNextSquare(155);
        long test2 = FindNextSquare(121);
        Console.WriteLine(test1);
        Console.WriteLine(test2);
    }
}
