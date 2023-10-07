using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        int number = 5;
        do{
            string userInput;
            Console.Clear();
            Console.WriteLine("Welcome to Mindfulness Activity!\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity\n2. Listing Activity\n3. Reflecting Activity\n4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            userInput = Console.ReadLine();
            number = Int32.Parse(userInput);

            if (number == 1)
            {
                BreathingActivity breathing1 = new BreathingActivity("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",0);
                breathing1.DisplayStartingMessage();
                string inputSeconds = Console.ReadLine();
                int seconds = Int32.Parse(inputSeconds);
                BreathingActivity breathing2 = new BreathingActivity("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", seconds);

                breathing2.Run(seconds);
                breathing2.DisplayEndingMessage();
            }

            else if (number == 2)
            {
                ListingActivity listing1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",0);
                listing1.DisplayStartingMessage();
                string inputSeconds = Console.ReadLine();
                int seconds = Int32.Parse(inputSeconds);
                ListingActivity listing2 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",seconds);

                listing2.Run(seconds);
                listing2.DisplayEndingMessage();
            }

            else if (number == 3)
            {
                ReflectingActivity reflecting1 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",0);
                reflecting1.DisplayStartingMessage();
                string inputSeconds = Console.ReadLine();
                int seconds = Int32.Parse(inputSeconds);
                ReflectingActivity reflecting2 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",seconds);

                reflecting2.Run(seconds);
                reflecting2.DisplayEndingMessage();
            }
        } while (number != 4);
        }

}
