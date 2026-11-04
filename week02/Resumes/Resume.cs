using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;

public class Resume
{
    public string _name = "James Smith";
    public List <Job> jobs = new List <Job> ();

public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in jobs)
        {
            job.Display();
        }
    }

}

