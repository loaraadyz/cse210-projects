public class CyclingActivity : Activity
{
    private double _speed { get; set; }

    public CyclingActivity(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculateDistance()
    {
        return (_speed * _minutes) / 60.0;
    }

    public override double CalculatePace()
    {
        return 60.0 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}: Speed {_speed:F1} kph, Distance {CalculateDistance():F1} km, Peace: {CalculatePace():F1} min per km";
    }

    public override string GetActivityType()
    {
        return "Cycling Activity";
    }
}