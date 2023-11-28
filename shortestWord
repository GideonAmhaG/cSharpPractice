using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;

public class centeredArray
{
    public static int FindShort(string s)
    {
        string[] words = s.Split(" ");
        int len = words[0].Length;
        foreach (string word in words)
        {
            if (word.Length <= len) len = word.Length;
        }
        return len;
    }

    public static void Main(string[] args)
    {
        int test1 = FindShort("bitcoin take over the world maybe who knows perhaps");
        int test2 = FindShort("turns out random test cases are easier than writing out basic ones");
        int test3 = FindShort("Let's travel abroad shall we");
        Console.WriteLine(test1);
        Console.WriteLine(test2);
        Console.WriteLine(test3);
    }
}
