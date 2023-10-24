public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, string address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;

    }

    public string GenerateDetailedLecture()
    {
        return base.GenerateStandardMessage() + $"\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

}