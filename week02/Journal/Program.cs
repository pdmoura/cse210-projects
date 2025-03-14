using System;
using System.Collections.Generic;
using System.IO;

// As a stretch to exceed the requirements, I added to the program I added the password feature for the journal so 
// that the user will only be able to load a file after typing the password that was defined when the file was saved.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        Console.WriteLine("Welcome to the Jornal Program!");

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string selectedPrompt = promptGen.GetRandomPrompt();
                    Console.WriteLine(selectedPrompt);
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry (selectedPrompt,response);
                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    journal.LoadFromFile();
                    break;
                case "4":
                    journal.SaveToFile();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    // Code to run if no case matches, kinda like else
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}