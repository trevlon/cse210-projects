using System.Diagnostics;

public class Reflecting:Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflecting(List<string> prompts, List<string> questions, string name):base(name)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        string name = "Reflecting";

         // Name from base class Activity
        // Console.WriteLine($"Welcome to the {name} Activity.");
        // Console.WriteLine();
        StartingMessage();

        // Description from base class Activity
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. \n" +
        "This will help you recognize the power you have and how you can use it in other aspects of your life.");
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
        Console.WriteLine("Consider the following Prompt:");

        // Get random prompt
        Random random = new Random();
        int index = random.Next(_prompts.Count());
        string randomPrompts = _prompts[index];
        Console.WriteLine();
        Console.WriteLine(randomPrompts);

        Console.WriteLine();
        Console.WriteLine("When you have something in mind press enter to continue.");
        Console.WriteLine();
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in...");
        ShowCountDown();
        Console.WriteLine();
        
        // make random object
        Random question = new Random();

        DateTime endTime = DateTime.Now.AddSeconds(userDurationTime);

        // Display random prompts until specified time by user ends
        while(DateTime.Now < endTime)
        {
            // Get random prompt
            int index2 = random.Next(_questions.Count());
            String randomQuestions = _questions[index2];
            Console.WriteLine($"{randomQuestions} ");
            ShowSpinner();
        }
        
        Console.WriteLine();
        EndMessage();
    }
}