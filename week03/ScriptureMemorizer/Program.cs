using System;
using System.Collections.Generic;
//As a way to exceed requirements I added the option for the user to show some words that were hidden by typing show.

class Program
{
    static void Main(string[] args)
    {
        //Using the second constructor of the Reference class
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words, type 'show' to reveal some hidden words, or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit")
            {
                break;
            }

            else if (input == "show")
            {
                scripture.ShowRandomWords(2); // Show 2 random hidden words
            }

            else
            {
                scripture.HideRandomWords(2);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}




