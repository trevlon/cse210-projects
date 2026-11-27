using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;


public class Listing:Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    private List<string> _fromUser = new List<string>();

    public Listing(int count, List<string> prompts, string name, string description, int duration):base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        string name = "Listing";

        // Name from base class Activity
        // Console.WriteLine($"Welcome to the {name} Activity.");
        // Console.WriteLine();
        StartingMessage();

        // Description from base class Activity
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things \n" +
        "as you can in a certain area.");
        Console.WriteLine();

        // Getting user time duration
        Console.Write("How long, in seconds, would you like your session? ");
        int userDurationTime = int.Parse(Console.ReadLine());
        _duration = userDurationTime;
        Thread.Sleep(userDurationTime);

        // Processing using spinner animation
        Console.WriteLine("Get Ready...");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following Prompt:");

        GetRandomPrompt();
        GetListFromUser();
        
        
        DateTime endTime = DateTime.Now.AddSeconds(userDurationTime);

        while(DateTime.Now < endTime)
        {
            GetListFromUser();
        }
        Console.WriteLine();
        EndMessage();
    }

    public void GetRandomPrompt()
    {
          // Get random prompts
        Random random = new Random();
        int index = random.Next(_prompts.Count());
        string randomPrompts = _prompts[index];
        Console.WriteLine(randomPrompts);

        // Number countdown
        Console.WriteLine("You may begin in: ");
        ShowCountDown();
    }

    public void GetListFromUser()
    {
        string response = Console.ReadLine();
        _fromUser.Add(response);  
        
    }
}