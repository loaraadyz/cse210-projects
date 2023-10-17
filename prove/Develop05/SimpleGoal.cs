public class SimpleGoal:Goal
{
    SimpleGoal():base()
    {
    }
    public SimpleGoal(string name, string description, string points, bool status): base (name, description, points)
    {
        _status = status;
    }

    public override void RecordEvent()
    {
        if (_status == false) {
            _status = true;
            Console.WriteLine($"\nCongratulations! You have earned {_points} points!");
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override int GetPoints()
    {
        bool status = IsComplete();
        if (status == true) 
        {
            return Convert.ToInt32(_points);
        }
        else
        {return 0;}

    }

    public override bool IsComplete()
    {
        if (_status == true) {
            return true;
        } else {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        string line = "";
        line = $"SimpleGoal:,{_shortName},{_description},{_points},{IsComplete().ToString()}";
        return line;
    }
}