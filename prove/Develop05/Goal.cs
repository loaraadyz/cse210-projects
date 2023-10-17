public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    protected bool _status;

    public Goal() 
    {
        _shortName = "Test Name";
        _description = "Test Description";
        _points = "50";
        _status = false;
    }

    public Goal(string name, string description, string points)
    {
        _shortName = name; 
        _description = description;
        _points = points;

    }

    public virtual void RecordEvent()
    {}

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        string statusSymbol = "";
        bool status = IsComplete();
        if (status == true) {
            statusSymbol = "X";
        } else {
            statusSymbol = " ";
        }
        string line = $"[{statusSymbol}] {_shortName} ({_description})";
        return line;
    }

    public virtual int GetPoints()
    {
        return Convert.ToInt32(_points);
    }

    public virtual string GetStringRepresentation()
    {
        string line = "";
        return line;
    }


}