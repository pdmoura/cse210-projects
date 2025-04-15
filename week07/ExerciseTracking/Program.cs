using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string date = DateTime.Now.ToString("dd MMM yyyy", new CultureInfo("en-US"));
        Running runningActivity = new Running(date, 30, 4.8);
        Console.WriteLine(runningActivity.GetSummary());
    }
}