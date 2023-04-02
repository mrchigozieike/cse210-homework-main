using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Add some activities to the list
        activities.Add(new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new CyclingActivity(new DateTime(2022, 11, 4), 60, 15.0));
        activities.Add(new SwimmingActivity(new DateTime(2022, 11, 5), 45, 20));

        // Print out the summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}





