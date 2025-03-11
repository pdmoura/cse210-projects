public class Resume
{
    public string _personName;
    public List<Job> _jobList = new List<Job>();

    // Constructor method
    public Resume()
    {
    }

    // Methods
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs: ");

        foreach (Job jobs in _jobList)
        {
            jobs.Display();
        }
    }
}