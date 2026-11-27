using System.ComponentModel;
using System.Diagnostics;

public class Breathe:Activity
{
    public Breathe(string name, string description, int duration):base(name, description, duration)
    {
        
    }

    public Breathe(string name):base(name)
    {
        
    }

    public void Run()
    {
        string name = "Breathing";

        // Name from base class Activity
        // Console.WriteLine($"Welcome to the {name} Activity.");
        // Console.WriteLine();
        StartingMessage();

        // Description from base class Activity
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. \n" +
        "Clear your mind and focus on your breathing.");
        Console.WriteLine();

        // Getting user time duration
        Console.Write("How long, in seconds, would you like your session? ");
        int userDurationTime = int.Parse(Console.ReadLine());
        _duration = userDurationTime;
        Thread.Sleep(userDurationTime);

        Console.WriteLine("Get Ready...");
        ShowSpinner();

        DateTime endTime = DateTime.Now.AddSeconds(userDurationTime);

        while(DateTime.Now < endTime)
        {
        Console.WriteLine();
        Console.Write("Breathe in...");
        ShowCountDown();
        Console.WriteLine();
        Console.Write("Breathe out...");
        ShowCountDown();
        Console.WriteLine();
        }
        
        Console.WriteLine();
        EndMessage();
    }
}