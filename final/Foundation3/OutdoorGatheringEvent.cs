public class OutdoorGatheringEvent : Event
{
    private string _weather;

    public OutdoorGatheringEvent(string title,string description,string date,string time,string address, string weather) : base (title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GenerateDetailedOutdoorEvent()
    {
        return base.GenerateStandardMessage() + $"\nWeather: {_weather}";
    }
}