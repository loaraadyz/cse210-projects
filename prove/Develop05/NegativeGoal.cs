public class NegativeGoal:Goal
{
    private int _stepCounter;
    public NegativeGoal()
    {
        _shortName = "";
        _description = "";
        _points = "";
        _stepCounter = 0;

    }
    public NegativeGoal(string name, string description, string points) : base(name, description, points)
    {
        _stepCounter = 0;
    }
    public override void RecordEvent()
    {
         _stepCounter ++;
        Console.WriteLine($"\nBummer! You have Lost {GetPoints()} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }
    public override int GetPoints()
    {
        return Convert.ToInt32(_points)*(-1);
    }


    public override string GetStringRepresentation()
    {
        string line = "";
        line = $"NegativeGoal:,{_shortName },{_description},{_points}";
        return line;
    }
}