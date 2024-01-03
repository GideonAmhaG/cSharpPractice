using System;

public class Solution
{
    public static string timeConversion(string s)
    {
        string[] par = s.Split(":");
        string last = par[2].Substring(0, 2);
        string amPm = par[2].Substring(2);
        int toInt = Int32.Parse(par[0]);
        string first = "";
        if (amPm == "AM")
        {
            if (par[0] == "12") first = "0" + (toInt - 12).ToString();
            else first = par[0];
        }  
        if (amPm == "PM")
        {
            if (par[0] == "12") first = par[0];
            else first = (toInt + 12).ToString();
        } 
        string res = first + ":" + par[1] + ":" + last; 
        return res;
    }
  
    public static void Main(string[] args)
    {
        string test1 = timeConversion("12:00:00AM");
        string test2 = timeConversion("01:00:00AM");
        string test3 = timeConversion("12:00:00PM");
        string test4 = timeConversion("01:00:00PM");
        Console.WriteLine(test1);
        Console.WriteLine(test2);
        Console.WriteLine(test3);
        Console.WriteLine(test4);
    }
}
