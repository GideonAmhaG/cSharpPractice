using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Solution
{
    public static int DuplicateCount(string str)
    {
        str = str.ToLower();
        string s = "";
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str.Length; j++)
            {
                if (i != j && str[j] == str[i] && !s.Contains(str[j]))
                {
                    s += str[j];
                    break;
                } 
            }
        }
        return s.Length;
    }

    public static void Main(string[] args)
    {
        int test1 = DuplicateCount("aA11a");
        Console.WriteLine(test1);
    }
}
