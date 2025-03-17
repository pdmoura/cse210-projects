using System;
using System.Collections.Generic;
using System.IO;

class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public JournalEntry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - Prompt: {Prompt}\nResponse: {Response}\n";
    }
}

class Journal
{
    private List<JournalEntry> entries;
    private static readonly List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public Journal()
    {
        entries = new List<JournalEntry>();
    }

    public void WriteNewEntry()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(prompts.Count);
        string selectedPrompt = prompts[randomIndex];

        Console.WriteLine($"Prompt: {selectedPrompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        JournalEntry newEntry = new JournalEntry(selectedPrompt, response);
        entries.Add(newEntry);

        Console.WriteLine("Entry added successfully!\n");
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found in the journal.");
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public void SaveJournalToFile()
    {
        Console.Write("Enter a filename to save the journal: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry.ToString());
                }
            }

            Console.WriteLine("Journal saved successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}\n");
        }
    }

    public void LoadJournalFromFile()
    {
        Console.Write("Enter a filename to load the journal from: ");
        string filename = Console.ReadLine();

        try
        {
            entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string prompt = line.Substring(6, 10);  // Assuming the date is at the beginning.
                    string response = reader.ReadLine().Substring(10);  // Skipping "Response: ".
                    entries.Add(new JournalEntry(prompt, response));
                    reader.ReadLine();  // Skip the blank line between entries.
                }
            }
            Console.WriteLine("Journal loaded successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}\n");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    journal.SaveJournalToFile();
                    break;
                case "4":
                    journal.LoadJournalFromFile();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
