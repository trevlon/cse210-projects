using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        ReferenceTrial locate = new ReferenceTrial("Philipians", 4, 6, 7);
        
        string scriptureText = 
        "Do not be anxious about anything, but in every situation, by prayer and petition, with thanksgiving, " +
        "present your requests to God. And the peace of God, which transcends all understanding," + 
        "will guard your hearts and your minds in Christ Jesus.";

        string joinText = locate.GetDisplayText().ToString() +"  "+ scriptureText;
        List<WordsTrial> listOfWords = new List<WordsTrial>();

        ScriptureTrial scripture = new ScriptureTrial(locate, scriptureText);

         string userResponse = "";

         while(userResponse.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if(scripture.IsCompletelyHidden() == true)
            {   
                break;
            }

            Console.WriteLine("Press enter to continue or type quit to end program:");
            userResponse = Console.ReadLine();

            if(userResponse == "quit")
            {
                break;
            }
            else
            { 
                scripture.HideRandomWords(3);
            }
        }

    }
}