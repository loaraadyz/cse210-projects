using System;

class Program
{
    static void Main(string[] args)
    {
        //variables
        int guess_number;
        int magic_number;

        //for Part 1 and 2
        //Console.Write("What is the magic number?");
        //magic_number = int.Parse(Console.ReadLine());

        Random random_generator = new Random();
        magic_number = random_generator.Next(1,101);

        do
        {
        Console.Write("What is the guess number?");
        guess_number = int.Parse(Console.ReadLine());
        
        if (guess_number > magic_number)
        {
            Console.WriteLine("Lower");
        }

        else if (guess_number <magic_number)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guess it!");
        }
        } while (magic_number != guess_number);

    }
}