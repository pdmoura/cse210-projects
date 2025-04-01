using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity activity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        string choice = "";
        while (choice != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            activity.DisplayActivityDescription();
            Console.Clear();
            
            if (choice == "1")
            {
                activity.StartActivity();
            }
        }
    }
}