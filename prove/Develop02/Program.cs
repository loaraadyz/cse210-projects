using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {

        Journal theJournal = new Journal();  
        PromptGenerator thePrompt = new PromptGenerator();

        thePrompt._prompts.Add("Who was the most interesting person I interacted with today?");
        thePrompt._prompts.Add("What was the best part of my day?");
        thePrompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        thePrompt._prompts.Add("What was the strongest emotion I felt today?");
        thePrompt._prompts.Add("If I had one thing I could do over today, what would it be?");

        int userChoice;
        do
        {
            Entry anEntry = new Entry();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            string user = Console.ReadLine();
            userChoice = int.Parse(user);


            if (userChoice == 1)
            {
                //set date
                DateTime theCurrentTime = DateTime.Now;
                anEntry._dateToday=theCurrentTime.ToShortDateString();
                //get random Prompt
                anEntry._promptText="Display Random Prompt: ";
                Console.WriteLine(anEntry._promptText);
                anEntry._entryText=Console.ReadLine();
                theJournal.AddEntry(anEntry);
            }

            else if (userChoice == 2)
            {
                theJournal.DisplayAll();
            }

            else if (userChoice == 3)
            {
                string file;
                Console.Write("What is the file name?");
                file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }

            else if (userChoice == 4)
            {
                string file;
                Console.Write("What is your file name?:");
                file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }
        } while (userChoice!=5);
        
        

    }
}