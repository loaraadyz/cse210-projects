public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity (string name,string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}");
        Console.WriteLine($"How long, in seconds, would you like for your session?");
        
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("\nWell done!!!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.\n");
        ShowSpinner(3);

    }

    public void ShowSpinner(int seconds)
    {
    {
        int spinnerPosition = 25;
        int spinWait = 500;

        spinnerPosition = Console.CursorLeft;

        DateTime futureTime = new DateTime();
        futureTime = DateTime.Now.AddSeconds(seconds);

        while(DateTime.Now < futureTime)
        {
            char[] spinChars = new char[]{'|','/','-','\\'};
            foreach (char spinChar in spinChars)
            {
                Console.CursorLeft = spinnerPosition;
                Console.Write(spinChar);
                Thread.Sleep(spinWait);
            }
        }
        Console.CursorLeft = spinnerPosition;
        Console.Write(" ");
    }
    }

    public void ShowCountDown(int seconds)
    {
        int timerPosition = 25;
        int timerWait = 1000;

        timerPosition = Console.CursorLeft;

        do
        {
            Console.CursorLeft = timerPosition;
            Console.Write(seconds);
            Thread.Sleep(timerWait);
            Console.Write("\b \b");
            seconds --;
        } while (seconds !=0);
        Console.CursorLeft = timerPosition;
        Console.Write(" ");
    }
}
