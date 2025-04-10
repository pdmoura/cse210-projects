public abstract class Goal
{
    protected string _shortName; 
    protected string _description;
    protected int _points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Abstract methods: Must be implemented by child classes.
    public abstract void RecordEvent(); // Tells what happens when the user completes the goal
    public abstract bool IsComplete(); // Check if goal is done
    public abstract string GetDetailsString(); // Return a human-readable string for listing
    public abstract string GetStringRepresentation(); // Returns a text version of the goal (used when saving to a file).

    // A quick helper method that just returns the number of points. (necessary for GoalManager)
    public int GetPoints()
    {
        return _points;
    }
}
