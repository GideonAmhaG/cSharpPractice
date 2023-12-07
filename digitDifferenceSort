using System;
using System.Linq;
using System.Runtime.CompilerServices;

public class Solution
{
    public static int[] DigitDifferenceSort(int[] a)
    {
        static int Diff(int n)
        {
            int len = n.ToString().Length;
            if (len == 1) return 0;
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = n % 10;
                n /= 10;
            }
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
            return arr[len - 1] - arr[0];
        }
        int idx = 0;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length - 1; j++)
            {
                if (Diff(a[j]) > Diff(a[j + 1]))
                {
                    int tmp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = tmp;
                }
            }
        }
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (Diff(a[i]) == Diff(a[j]))
                {
                    int tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                }
            }
        }
        return a;
    }

    public static void Main(string[] args)
    {
        int[] test1 = DigitDifferenceSort(new int[]{152, 23, 7, 887, 243});
        int[] test2 = DigitDifferenceSort(new int[]{13098, 1308, 12398, 52433, 213, 424, 213, 243, 12213, 54234, 99487, 81892, 11111, 97897});
        Console.WriteLine(string.Join(", ", test1));
        Console.WriteLine(string.Join(", ", test2));
    }
}
