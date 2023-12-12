using System;
using System.Linq;
using System.Runtime.CompilerServices;

public class Solution
{
    public static (int, int)? IsPerfectPower(int n)
    {
        for (int i = 2; i * i <= n; i++)
        {
            int j = Convert.ToInt32(Math.Log(n, i));
            if (Math.Pow(i, j) == n) return (i, j);
        }
        return null;
    }

    public static void Main(string[] args)
    {
        (int, int)? test1 = IsPerfectPower(81);
        (int, int)? test2 = IsPerfectPower(243);
        Console.WriteLine(test1);
        Console.WriteLine(test2);
    }
}
