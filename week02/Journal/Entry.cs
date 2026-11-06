using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
   
       // Member variables
       public string _date;
       public string _prompt;
       public string _response;

    // Constructor
    public Entry(string date, string prompt, string response){
         _date = date;
         _prompt = prompt;
         _response = response;
    }
    
    public void Display()
    {
        Console.WriteLine($"Date:{_date}");
        Console.WriteLine($"Prompt:{_prompt}");
        Console.WriteLine($"Response:{_response}");
    }
}

