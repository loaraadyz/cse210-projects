public class Activity
{
    private DateTime _date { get; set; }
    protected int _minutes { get; set; }

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }

    public virtual double CalculateSpeed()
    {
        return 0;
    }

    public virtual double CalculatePace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy}: {GetActivityType()} ({_minutes} min)";
    }

    public virtual string GetActivityType()
    {
        return "Activity";
    }
}