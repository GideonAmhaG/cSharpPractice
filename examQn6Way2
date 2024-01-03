using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Solution
{
    public static int f(int[] a)
    {
        if (a.Length < 3) return -1;
        int idx = 0;
        int l = 0, r = a.Length - 1;
        int lSum = a[l], rSum = a[r];
        for (int k = 1; k < a.Length - 2; k++)
        {
            if (lSum < rSum)
            {
                l++;
                lSum += a[l];
                idx = l + 1;
            }
            else
            {
                r--;
                rSum += a[r];
                idx = r - 1;
            }
        }
        if (lSum == rSum) return idx;
        return -1;
    }

    public static void Main(string[] args)
    {
        int[] exampleArray1 = new int[] {1, 8, 3, 7, 10, 2};
        int[] exampleArray2 = new int[] {1, 5, 3, 1, 1, 1, 1, 1, 1};
        int[] exampleArray3 = new int[] {2, 1, 1, 1, 2, 1, 7};
        int[] exampleArray4 = new int[] {1, 2, 3};
        int[] exampleArray5 = new int[] {3, 4, 5, 10};
        int[] exampleArray6 = new int[] {1, 2, 10, 3, 4};
        
        Console.WriteLine(f(exampleArray1));
        Console.WriteLine(f(exampleArray2));
        Console.WriteLine(f(exampleArray3));
        Console.WriteLine(f(exampleArray4));
        Console.WriteLine(f(exampleArray5));
        Console.WriteLine(f(exampleArray6));
    }
}
