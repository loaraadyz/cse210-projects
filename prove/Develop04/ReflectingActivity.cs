public class ReflectingActivity:Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string title, string description, int duration) : base (title, description,duration)
    {}

    public void Run(int seconds)
    {
        _prompts.Add("--Think of a time when you stood up for someone else.--");
        _prompts.Add("--Think of a time when you did something really difficult.--");
        _prompts.Add("--Think of a time when you helped someone in need.--");
        _prompts.Add("--Think of a time when you did something truly selfless.--");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string input = Console.ReadLine();

        if (input=="")
        {
            Console.Clear();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin: ");
            ShowCountDown(5);

            DateTime futureTime = new DateTime();
            futureTime = DateTime.Now.AddSeconds(seconds);

            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;

            while (currentTime<=futureTime)
            {
                DisplayQuestion();
                ShowSpinner(10);
                currentTime = DateTime.Now; 
            }
        }
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        string prompt = _prompts[index];
        return prompt;
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);

        string question = _questions[index];
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine("");
        Console.Write(question);
        _questions.Remove(question);
    }


}