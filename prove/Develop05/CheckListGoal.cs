using System;

public class CheckListGoal : Goal
{
    private string _goalType = "CheckList";
    private int _goalPoints;
    private int _goalTimes;
    private int _goalBonus;
    private int _timesCompleted = 0;
    private int _totalPoints = 0;
    private bool _goalComplete;

    public CheckListGoal() { }

    public CheckListGoal(string goalName, string goalDescription, int goalPoints, int goalTimes, int timesCompleted, int goalBonus, bool goalComplete)
        : base(goalName, goalDescription)
    {
        _goalPoints = goalPoints;
        _goalTimes = goalTimes;
        _timesCompleted = timesCompleted;
        _goalBonus = goalBonus;
        _goalComplete = goalComplete;
    }

    public int GetRunningTotal()
    {
        return _timesCompleted;
    }

    public int GetGoalTimes()
    {
        return _goalTimes;
    }

    public int GetGoalBonus()
    {
        return _goalBonus;
    }

    public override void DisplayGoalPoints()
    {
        Console.Write("How many points is each time you complete this goal worth? ");
        _goalPoints = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _goalTimes = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _goalBonus = int.Parse(Console.ReadLine());
    }

    public override int GetGoalPoints()
    {
        return _goalPoints;
    }

    public override bool GetGoalStatus()
    {
        return _goalComplete;
    }

    public override string ToCSVRecord()
    {
        return $"{_goalType}|{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{GetGoalTimes()}|{GetRunningTotal()}|{GetGoalBonus()}|{_goalComplete}";
    }

    public override string ToString()
    {
        return $"[ ] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed: {GetRunningTotal()}/{GetGoalTimes()}";
    }

    public override void RecordEvent()
    {
        _timesCompleted += 1;

        if (_timesCompleted == _goalTimes)
        {
            _goalComplete = true;
            Console.WriteLine($"Congratulations! You have earned {GetGoalBonus()} bonus points!");
            _totalPoints += _goalBonus;
        }
        else
        {
            _totalPoints += _goalPoints;
            Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
        }
    }
}
