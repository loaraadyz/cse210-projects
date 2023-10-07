using System.Runtime.Serialization;

public class ListingActivity:Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();
    private List<string> _responses = new List<string>();

    public ListingActivity(string title, string description, int duration ):base(title, description, duration)
    {
    }

    public void Run(int seconds)
    {

        _prompts.Add("--Who are people that you appreciate?--");
        _prompts.Add("--What are personal strengths of yours?--");
        _prompts.Add("--Who are people that you have helped this week?--");
        _prompts.Add("--When have you felt the Holy Ghost this month?--");
        _prompts.Add("--Who are some of your personal heroes?--");

        Console.Clear();
        Console.WriteLine("Get ready...");

        DateTime futureTime = new DateTime();
        futureTime = DateTime.Now.AddSeconds(seconds);

        DateTime currentTime = new DateTime();
        currentTime = DateTime.Now;

        ShowSpinner(3);

        string prompt = GetRandomPrompt();
        
        Console.WriteLine("List as many responses you can to the following prompt");
        Console.WriteLine(prompt);
        Console.Write("\nYou may begin in: ");
        ShowCountDown(3);
        Console.WriteLine("");

        while (currentTime<=futureTime)
        {
            GetListFromUser();
            currentTime = DateTime.Now; 
            _count++;
        }

        Console.WriteLine($"You listed {_count} items!");
        Console.Write("\nHere are your responses...\n");
        Console.WriteLine("");
        PrintResponses();
        ShowSpinner(5);
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        string prompt = _prompts[index];

        return prompt;
    }

    public void GetListFromUser()
    {
        Console.Write(">");
        string response = Console.ReadLine();
        _responses.Add(response);
    }

    public void PrintResponses()
    {
        int index = 0;
        while (index != _responses.Count())
        {
            Console.WriteLine(_responses[index]);
            index++;
        }
    }
}
