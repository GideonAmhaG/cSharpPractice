using System;

public class Solution
{
    public static int[] VideoPart(string part, string total)
    {
        string[] totalArr = total.Split(":");
        string[] partArr = part.Split(":");
        int totalInt = int.Parse(totalArr[0]) * 3600 + int.Parse(totalArr[1]) * 60 + int.Parse(totalArr[2]);
        int partInt = int.Parse(partArr[0]) * 3600 + int.Parse(partArr[1]) * 60 + int.Parse(partArr[2]);
        int GCD(int a, int b)
        {
            while (b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }
        int gcd = GCD(totalInt, partInt);
        int[] res = new int[] {partInt / gcd, totalInt / gcd};
        return res;
    }

    public static void Main(string[] args)
    {
        int[] test1 = VideoPart("02:20:00","07:00:00");
        int[] test2 = VideoPart("25:26:20","25:26:20");
        int[] test3 = VideoPart("00:02:20","00:10:00");
        Console.WriteLine(string.Join(", ", test1));
        Console.WriteLine(string.Join(", ", test2));
        Console.WriteLine(string.Join(", ", test3));
    }
}
