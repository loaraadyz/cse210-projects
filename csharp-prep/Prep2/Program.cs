using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string grade_percentage = Console.ReadLine();
        int grade = int.Parse(grade_percentage);

        string letter_grade = "";

        if (grade >= 90)
        {
            letter_grade = "A";
        }
        else if (grade >= 80)
        {
            letter_grade = "B";
        }
        else if (grade >= 70)
        {   
            letter_grade = "C";
        }
        else if (grade >= 60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "F";
        } 

        Console.WriteLine($"Your grade is: {letter_grade}");

        if (grade >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }     
    }
}