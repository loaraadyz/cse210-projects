class SwimmingActivity : Activity
{
    private int _laps { get; set; }

    public SwimmingActivity(DateTime date, int minutes, int laps) : base(date,minutes)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return (_laps * 50) / 1000.0;
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / (_minutes / 60.0);
    }

    public override double CalculatePace()
    {
        return _minutes / CalculateDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}: Distance {CalculateDistance():F1} km, Speed {CalculateSpeed():F1} min per km";
    }

    public override string GetActivityType()
    {
        return "Swimming";
    }
}