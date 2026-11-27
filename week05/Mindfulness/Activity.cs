public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

     public Activity(string name)
    {
        _name = name;
    }

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
    }

    public void EndMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner();

        int ratings = 0;

        while(ratings > 10 || ratings < 1)
        {
            Console.WriteLine();
            Console.WriteLine("Rate this activity from 1 to 10:");

            ratings = int.Parse(Console.ReadLine());

            // Console.WriteLine($"You've rated the breathing activity {ratings} out of 10");
            // Console.WriteLine(); 

        if(ratings > 10)
        {
            Console.WriteLine("Please stay within the range of 10");
        }
        }
        Console.WriteLine($"You've rated the breathing activity {ratings} out of 10");
        Console.WriteLine(); 
    }

    public void ShowSpinner()
    {
        // First rotation
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("");
   
    }

    public void ShowCountDown()
    {
        Console.Write(5);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(4);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(3);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(2);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(1);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(0);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("");
    }
}
