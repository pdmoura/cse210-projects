public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            _isComplete = true;
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }

    //Setter for isComplete
    public void SetIsComplete(bool completed)
    {
        _isComplete = completed;
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}
