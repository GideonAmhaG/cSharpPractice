using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Solution
{
    public static String Accum(string s)
    {
        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (j == 0) res += char.ToUpper(s[i]);
                else res += char.ToLower(s[i]);
            }
            if (i != s.Length - 1) res += "-";
        }
        return res;
    }

    public static void Main(string[] args)
    {
        string test1 = Accum("abcd");
        Console.WriteLine(test1);
    }
}
