public class RunningActivity : Activity{
    private double _distance { get; set; }

    public RunningActivity(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return _distance / (_minutes / 60.0);
    }

    public override double CalculatePace()
    {
        return _minutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}: Distance {_distance:F1} miles, Speed {CalculateSpeed():F1} mph, Pace: {CalculatePace():F1} min per mile";
    }

    public override string GetActivityType()
    {
        return "Running";
    }
}
