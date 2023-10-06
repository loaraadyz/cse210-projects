using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Assignment student1 = new Assignment("Loara Adyz Villa", "Multiplication");
        Console.WriteLine(student1.GetSummary());

        Console.WriteLine("");
        MathAssignment assignment1 = new MathAssignment("Loara Adyz", "Multiplication", "Sectioons 1-20", "Problems 1-5");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());

        Console.WriteLine("");
        WritingAssignment writing1 = new WritingAssignment("Loara Adyz", "European History", "The Cause of World War II by  Mary Waters");
        Console.WriteLine(writing1 .GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}