public class CheckListGoal : Goal
{
    private int _amountCompleted; // How many times this has been done
    private int _target; // How many times it needs to be done
    private int _bonus; // Bonus points when completed

    // Constructor that sets up a checklist goal with all its values.
    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0; // Start at 0
        _target = target;
        _bonus = bonus;
    }

    //Methods

    //Method that increases the progress, gives a bonus when the goal is fully done, and handles already-finished goals.
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Progress made! {_amountCompleted}/{_target} completed.");
            if (IsComplete())
            {
                Console.WriteLine($"Bonus achieved! You earned {_bonus} bonus points!");
            }
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
        // Returns true if we've done it enough times
    }

    public override string GetDetailsString()
    {
        //Using ternary-operator fills the checklist if completed
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }


    //Creating Setter for _amountCompleted
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
}
