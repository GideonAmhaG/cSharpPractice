using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class R13
{
    public static string formatDuration(int seconds)
    {
        if (seconds == 0) return "now";
        int minute = 60;
        int hour = minute * 60;
        int day = hour * 24;
        int year = day * 365;
        int years = seconds / year;
        int days = (seconds % year) / day;
        int hours = (seconds % day) / hour;
        int minutes = (seconds % hour) / minute;
        int secs = seconds % minute;
        List<string> time = new List<string>();
        if (years > 0) time.Add(years + (years == 1 ? " year" : " years"));
        if (days > 0) time.Add(days + (days == 1 ? " day" : " days"));
        if (hours > 0) time.Add(hours + (hours == 1 ? " hour" : " hours"));
        if (minutes > 0) time.Add(minutes + (minutes == 1 ? " minute" : " minutes"));
        if (secs > 0) time.Add(secs + (secs == 1 ? " second" : " seconds"));
        string res = string.Join(", ", time);
        int lastComma = res.LastIndexOf(',');
        if (lastComma != -1) res = res.Substring(0, lastComma) + " and" + res.Substring(lastComma + 1);
        return res;
    }

    public static void Main(string[] args)
    {
        string test1 = formatDuration(1);
        string test2 = formatDuration(120);
        string test3 = formatDuration(3601);
        string test4 = formatDuration(15731080);
        string test5 = formatDuration(132030240);
        Console.WriteLine(test1);
        Console.WriteLine(test2);
        Console.WriteLine(test3);
        Console.WriteLine(test4);
        Console.WriteLine(test5);
    }
}
