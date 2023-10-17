public class EternalGoal:Goal   
{
    private int _stepCounter;
    public EternalGoal()
    {
        _shortName = "";
        _description = "";
        _points = "";
        _stepCounter = 0;

    }
    public EternalGoal(string name, string description, string points):base(name, description, points)
    {
        _stepCounter = 0;
    }
    public override void RecordEvent()
    {
         _stepCounter ++;
         Console.WriteLine($"\nCongratulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override int GetPoints()
    {
        return Convert.ToInt32(_points);
    }

    public override string GetStringRepresentation()
    {
        string line = "";
        line = $"EternalGoal:,{_shortName },{_description},{_points}";
        return line;
    }


}