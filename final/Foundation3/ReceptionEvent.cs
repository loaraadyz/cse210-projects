public class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title,string description,string date,string time,string address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public string GenerateDetailedReception()
    {
        return base.GenerateStandardMessage() + $"\nEmail: {_email}";
    }
}