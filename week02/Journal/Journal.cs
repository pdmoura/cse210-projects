public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    // Constructor
    public Journal()
    {
    }

    // Methods of the class
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!\n");
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found in the journal.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter a filename to save the journal: ");
        string fileName = Console.ReadLine();

        string existingPassword = null;

        // Check if file already exists
        if (File.Exists(fileName))
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string firstLine = reader.ReadLine();
                    if (firstLine.StartsWith("PASSWORD:"))
                    {
                        existingPassword = firstLine.Substring(9); // Extract the saved password
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading existing file: {ex.Message}\n");
            }
        }

        // Ask for a password only if the file is new
        if (existingPassword == null)
        {
            Console.Write("Set a password to protect this journal: ");
            existingPassword = Console.ReadLine();
        }
        
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine($"PASSWORD:{existingPassword}"); // Keep the original password

                foreach (var entry in _entries)
                {
                    writer.WriteLine(entry.MakeEntryText());
                }
            }

            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}\n");
        }
    }



    public void LoadFromFile()
    {
        Console.Write("Enter a filename to load the journal from: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                // Read and verify password
                string firstLine = reader.ReadLine();

                string storedPassword = firstLine.Substring(9); // Extract stored password
                Console.Write("Enter the password: ");
                string enteredPassword = Console.ReadLine();

                // If the password is incorrect, tell the user and stop the program
                if (enteredPassword != storedPassword)
                {
                    Console.WriteLine("Incorrect password! Access denied.");
                    return;
                }
                // If the password is correct, load the file
                _entries.Clear();

                // Load the rest of the journal entries
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string prompt = line.Substring(26); // Ignore the date and get only the prompt.
                    string response = reader.ReadLine();
                    _entries.Add(new Entry(prompt, response));
                    reader.ReadLine();  // Skip the blank line between _entries.
                }
            }

            Console.WriteLine("Journal loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}\n");
        }
    }

}

