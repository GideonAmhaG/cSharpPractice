using System;

public class Solution
{
    public static void bonAppetit(List<int> bill, int k, int b)
    {
        int len = bill.Count;
        int sum = 0;
        for (int i = 0; i < len; i++)
        {
            if (i != k) sum += bill[i];
        }
        if (b - (sum / 2) == 0) Console.WriteLine("Bon Appetit");
        else Console.WriteLine(b - (sum / 2));
    }
  
    public static void Main(string[] args)
    {
        bonAppetit(new List<int> {3, 10, 2, 9}, 1, 12);
        
        //Console.WriteLine(test1);
    }
}
