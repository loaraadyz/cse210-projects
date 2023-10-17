using System.Net.WebSockets;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _targetCounter;


    public ChecklistGoal()
    {
        _shortName="";
        _description="";
        _points="";
        
    }

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int targetCounter) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _targetCounter = targetCounter;
    }

    public override void RecordEvent()
    {
        _targetCounter ++;
        Console.WriteLine($"\nCongratulations! You have earned {_points} points!");
    }

    public override int GetPoints()
    {
        int points = 0;

        points = _targetCounter * Int32.Parse(_points);

        bool status = IsComplete();

        if (status == true) {
            points += _bonus;
        }

        return points;

    }


    public override bool IsComplete()
    {
        if (_targetCounter >= _target) {
            return true;
        } else {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string statusSymbol = "";
        bool status = IsComplete();
        if (status == true) {
            statusSymbol = "X";
        } else {
            statusSymbol = " ";
        }

        string line = $"[{statusSymbol}] {_shortName} ({_description}) -- Currently Completed {_targetCounter}/{_target}";
        return line;
    }

    public override string GetStringRepresentation()
    {
        string line = "";
        line = $"ChecklistGoal:,{_shortName},{_description},{_points},{_bonus},{_target},{_targetCounter}";
        return line;
    }


}
