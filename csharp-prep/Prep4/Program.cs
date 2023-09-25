using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers =  new List<int>();
        int number;
        do
        { 
            Console.Write("Enter a list of numbers, type 0 when your done:");
            string response = Console.ReadLine();
            number = int.Parse(response);
            numbers.Add(number);
        } while (number != 0);

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sume is: {sum}");

        float average = ((float)sum)/(numbers.Count-1);
        Console.WriteLine($"The average is: {average}");

        int max= numbers[0];
        foreach (int num in numbers)
        {
            if (num>max)
            {
                max = num;
            }
        }
        Console.WriteLine ($"The maximum number is: {max}");
    }
}