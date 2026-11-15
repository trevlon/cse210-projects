/*
Purpose: To help the user learn a scripture by replacimg certain words with underscore to help with memorizing scripture

Exceeding Requirements: The user gets prompted to choose from two scriptures, if the user type 1 they choose Phillipians 4:6-7, 
                        if they type 2 they choose Romans 10:9-10, you will see the options when you start the program

Note: You have to choose one of the scriptures from the list, you cannot type quit before choosing a scripture
*/
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class ProgramCopy
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        // First scripture
        ReferenceTrial locate = new ReferenceTrial("Philipians", 4, 6, 7);
        
        string scriptureText = 
        "Do not be anxious about anything, but in every situation, by prayer and petition, with thanksgiving, " +
        "present your requests to God. And the  peace of God, which transcends all understanding," + 
        " will guard your hearts and your minds in Christ Jesus.";

        string joinText = locate.GetDisplayText().ToString() +"  "+ scriptureText;
        List<WordsTrial> listOfWords = new List<WordsTrial>();

        ScriptureTrial scripture = new ScriptureTrial(locate, scriptureText);
        
        // Second scripture
        ReferenceTrial locateTwo = new ReferenceTrial("Romans", 10, 9, 10);
 
        string scriptureTextTwo = "If you declare with your mouth, “Jesus is Lord, "+
        "and believe in your heart that God raised him from the dead, "+
        "you will be saved. For it is with your heart that you believe and are justified, "+
        "and it is with your mouth that you profess your faith and are saved.";

        ScriptureTrial scriptureTwo = new ScriptureTrial(locateTwo, scriptureTextTwo);

        Console.WriteLine("Which scripture do you want?:");
        Console.WriteLine("1.Philipians 4:6-7");
        Console.WriteLine("2.Romans 10:9-10");
        string userChoice = Console.ReadLine();

         string userResponse = "";

         while(userResponse.ToLower() != "quit")
        {
            // First option
            if(userChoice == "1")
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

            // Second option
            if(userChoice == "2")
            {
            Console.Clear();
            Console.WriteLine(scriptureTwo.GetDisplayText());

            if(scriptureTwo.IsCompletelyHidden() == true)
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
                scriptureTwo.HideRandomWords(3);
            }
            }
                
            }
        }

    }
