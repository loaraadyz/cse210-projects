using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        LectureEvent lecture1 = new LectureEvent("Finding Faith in Christ", "This event is for the youth with a purpose of helping them learn and know Jesus Christ", "January 13, 2024", "3:00 PM","Imelda, Naguilian, La Union, Philippines", "Mervin Duldulao", 50);
        ReceptionEvent reception1 = new ReceptionEvent("Riccy and Kathy Wedding", "It is the reception event of the weding of Mr. and Mrs. Andallo", "June 13, 2024","12:00NN", "Ortiz, Naguilian, La Union", "jericho.rivera@gmail.com");
        OutdoorGatheringEvent outdoor1 = new OutdoorGatheringEvent("Teacher's Camp", "The teachers of NNHS will be having their 3-Day Camp", "December 23-25, 2023", "8:00AM", "Santo Tomas, La Union, Philippines", "sunny");

        Console.WriteLine("\nDETAILED MESSAGE\n");

        Console.WriteLine(lecture1.GenerateDetailedLecture());
        Console.WriteLine();
        Console.WriteLine(reception1.GenerateDetailedReception());
        Console.WriteLine();
        Console.WriteLine(outdoor1.GenerateDetailedOutdoorEvent());
        Console.WriteLine();

        Console.WriteLine("STANDARD MESSAGE\n");

        Console.WriteLine(lecture1.GenerateStandardMessage());
        Console.WriteLine();
        Console.WriteLine(reception1.GenerateStandardMessage());
        Console.WriteLine();
        Console.WriteLine(outdoor1.GenerateStandardMessage());
        Console.WriteLine();


        Console.WriteLine("SHORT MESSAGE\n");
        Console.WriteLine(lecture1.GenerateShortMessage());
        Console.WriteLine();
        Console.WriteLine(reception1.GenerateShortMessage());
        Console.WriteLine();
        Console.WriteLine(outdoor1.GenerateShortMessage());
        Console.WriteLine();

    }
}