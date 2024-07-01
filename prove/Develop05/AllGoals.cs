using System;
using System.Collections.Generic;

public class AllGoals
{
    private List<Goal> _goals;
    private int _totalPoints;

    public AllGoals()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void SetGoals(List<Goal> goals)
    {
        _goals = goals;
    }

    public void addGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");
        int goalIndex = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goalIndex}. {goal.ToString()}");
            goalIndex++;
        }
    }

    public void DisplayPoints(int points)
    {
        Console.WriteLine($"You have {points} points.");
    }

    public void DisplayGoalRecordEvent()
    {
        DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        int userInput = int.Parse(Console.ReadLine()) - 1;

        if (userInput < _goals.Count)
        {
            Goal accomplishedGoal = _goals[userInput];
            accomplishedGoal.RecordEvent();
            _totalPoints += accomplishedGoal.GetGoalPoints();
        }
        else
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
    }

    public int getTotalPoints()
    {
        return _totalPoints;
    }

    public void SaveGoals()
    {
        List<string> goalRecords = new List<string>();
        foreach (Goal goal in _goals)
        {
            goalRecords.Add(goal.ToCSVRecord());
        }

        SaveLoadCSV.SaveToCSV(goalRecords, "goals.csv");
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        List<string> loadedRecords = SaveLoadCSV.LoadFromCSV("goals.csv");
        foreach (string record in loadedRecords)
        {
            string[] recordParts = record.Split('|');
            Goal goal = null;

            switch (recordParts[0])
            {
                case "Simple":
                    goal = new SimpleGoal(recordParts[1], recordParts[2], int.Parse(recordParts[3]), bool.Parse(recordParts[4]));
                    break;
                case "Eternal":
                    goal = new EternalGoal(recordParts[1], recordParts[2], int.Parse(recordParts[3]), int.Parse(recordParts[4]), bool.Parse(recordParts[5]));
                    break;
                case "CheckList":
                    goal = new CheckListGoal(recordParts[1], recordParts[2], int.Parse(recordParts[3]), int.Parse(recordParts[4]), int.Parse(recordParts[5]), int.Parse(recordParts[6]), bool.Parse(recordParts[7]));
                    break;
            }

            if (goal != null)
            {
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}
