public class BreathingActivity:Activity
{
    public BreathingActivity(string title, string description, int seconds) : base (title, description, seconds)
    {}

    public void Run(int seconds)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");

        DateTime futureTime = new DateTime();
        futureTime = DateTime.Now.AddSeconds(seconds);

        DateTime currentTime = new DateTime();
        currentTime = DateTime.Now;

        ShowSpinner(3);

        Console.Write("\nBreathe in...");
        ShowCountDown(3);
        Console.Write("\nBreathe out...");
        ShowCountDown(3);

        while (currentTime<=futureTime)
        {
            Console.WriteLine("");
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nBreathe out...");
            ShowCountDown(6);      
            currentTime = DateTime.Now; 
        }

    }
}