using System;
using System.Diagnostics.CodeAnalysis;

public class Solution
{
    public static bool IsValidWalk(string[] walk)
    {
       if (walk.Length != 10) return false;
       int x = 0, y = 0;
       foreach (string dir in walk)
       {
            switch(dir)
            {
                case "n":
                    y++;
                    break;
                case "s":
                    y--;
                    break;
                case "e":
                    x++;
                    break;
                case "w":
                    x--;
                    break;
                default: 
                    return false;
            }
       }
       return x == 0 && y == 0;
    }

    public static void Main(string[] args)
    {
        bool test1 = IsValidWalk(new string[] {"n","s","n","s","n","s","n","s","n","s"});
        bool test2 = IsValidWalk(new string[] {"w","e","w","e","w","e","w","e","w","e","w","e"});
        bool test3 = IsValidWalk(new string[] {"w"});
        bool test4 = IsValidWalk(new string[] {"n","n","n","s","n","s","n","s","n","s"});
        Console.WriteLine(test1);
        Console.WriteLine(test2);
        Console.WriteLine(test3);
        Console.WriteLine(test4);
    }
}
