public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int i = 0;
    private string _userInput;
    public GoalManager()
    {}

    public void Start()
    
    {
        string userInput = "0";
        do
        {
            Console.WriteLine($"You have {_score} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice form the menu:");
            string _userInput = Console.ReadLine();

            if (_userInput == "1")
            {
                CreateGoal();
            }
            else if (_userInput =="2")
            {
                ListGoalDetails();
            }
            else if (_userInput == "3")
            {
                SaveGoals();
            }
            else if (_userInput == "4")
            {
                LoadGoals();
            }
            else if (_userInput == "5")
            {
                RecordEvent();
            }
            else if (_userInput == "6")
            {
                userInput = "6";
            }
        } while (userInput != "6");


    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine(_score);
    }

   // public void ListGoalNames()
  //  {
   //     foreach (List<Goal> goal in _goals)
   //     {
   //         Console.WriteLine(goal._name);
   //     }
  //  }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++) {
            Console.Write($"{i + 1}. ");
            string line = _goals[i].GetDetailsString();
            Console.WriteLine($"{line}");
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The type of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine(" 4. Negative Goal");
        Console.Write("Which tye of goal would you like to Create?:");
        string type = Console.ReadLine();
        if (type == "1")
        {
            Console.Write("What is the name of your goal?:");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it?:");
            string description  = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal?  ");
            string points = Console.ReadLine();
            SimpleGoal simpleGoal = new SimpleGoal(name,description,points,false);
            _goals.Add(simpleGoal);
        }
        if (type == "2")
        {
            Console.Write("What is the name of your goal?:");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it?:");
            string description  = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal?  ");
            string points = Console.ReadLine();
            EternalGoal eternalGoal = new EternalGoal(name,description,points);
            _goals.Add(eternalGoal);
        }
        if (type == "3")
        {
            Console.Write("What is the name of your goal?:");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it?:");
            string description  = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal?  ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus?:");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times?:");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checkListGoal = new ChecklistGoal(name,description,points,target,bonus,0);
            _goals.Add(checkListGoal);
        }
        if (type == "4")
        {
            Console.Write("What is the name of your goal?:");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it?:");
            string description  = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal?  ");
            string points = Console.ReadLine();
            NegativeGoal negativeGoal = new NegativeGoal(name,description,points);
            _goals.Add(negativeGoal);        
        }

    }

    public void RecordEvent()
    {
        string goalIndex = "";
        Console.Write("Which goal did you accomplish? ");
        goalIndex = Console.ReadLine();
        int goalIndexInt = Convert.ToInt32(goalIndex) - 1;

        if (_goals[goalIndexInt].IsComplete() == false) {

            _goals[goalIndexInt].RecordEvent();

            int pointsEarned = _goals[goalIndexInt].GetPoints();

            _score += pointsEarned;

            Console.WriteLine($"\nYou now have {_score} points");

        } else {

            Console.WriteLine("You have already completed this goal.");

        }
    }
    
    public void SaveGoals()
    {
        Console.Write("\nWhat is the name for this goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            // Save Total Points
            outputFile.WriteLine(_score.ToString());
            // Save goals list
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nWhat is the name of your goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            // read the first line of text file for total stored points
            int totalPoints = int.Parse(readText[0]);
            _score = totalPoints;
            // skip the first line of text file to read to goals
            readText = readText.Skip(1).ToArray();
            // loop though text file for goals
            foreach (string line in readText)
            {
                string[] entries = line.Split(",");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                string points = entries[3];
                

                if (type == "SimpleGoal:")
                {
                    bool status = Convert.ToBoolean(entries[4]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points, status);
                    _goals.Add(simpleGoal);
                }
                if (type == "EternalGoal:")
                {
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                }
                if (type == "ChecklistGoal:")
                {
                    int bonus = int.Parse(entries[4]);
                    int target = int.Parse(entries[5]);
                    int targetCounter = int.Parse(entries[6]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus, targetCounter);
                    _goals.Add(checklistGoal);
                }
                if (type == "NegativeGoal:")
                {
                    NegativeGoal negativeGoal = new NegativeGoal(name, description, points);
                    _goals.Add(negativeGoal);
                }
                
            }
        }
    }


}