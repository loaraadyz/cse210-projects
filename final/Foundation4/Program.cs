using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Activity runningActivity = new RunningActivity(DateTime.Now, 100, 7.0);
        Activity bicycleActivity = new CyclingActivity(DateTime.Now, 55, 25.0);
        Activity swimmingActivity = new SwimmingActivity(DateTime.Now, 120, 80);

        activities.Add(runningActivity);
        activities.Add(bicycleActivity);
        activities.Add(swimmingActivity);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}