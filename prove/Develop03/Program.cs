using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Scripture object
        
        ScriptureGenerator theScripture = new ScriptureGenerator();
        Scripture scripture = theScripture.GetRandomScripture();

        string userInput;
        // Main loop
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            userInput = Console.ReadLine().ToLower();

            if (userInput == "" && !scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(1);
            }
            else if (userInput == "" && scripture.IsCompletelyHidden())
            {
                userInput = "quit";
            }
            else
            {
                Console.WriteLine("Invalid input. Press Enter to continue...");
                Console.ReadLine();
            }
        } while (userInput != "quit");

        Console.WriteLine("Program ended.");
    }
}