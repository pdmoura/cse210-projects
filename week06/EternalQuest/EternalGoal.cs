public class EternalGoal : Goal
{
    // Calls the base class constructor to initialize fields
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    // When the user completes this goal, we just print a congratulation message
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return false; // This goal is never complete — it's eternal!
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
        //Ex: [ ] (Say thank you) (Do it every day)
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
        // Returns a text version of the goal (used when saving to a file).
    }
}