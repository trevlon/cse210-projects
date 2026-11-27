/*
  Purpose: Make a Program that helps people take time for mindfulness and reflection

  Exceeding Expectations: Made a rating system out of 10, if the user type a number greater than 10, then a message will be displayed,
  saying to stay within the range, this statement will repeat until they enter a rating within the range of 10.
*/
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");
        // Activity activity = new Activity("Breath", "Great Day Today", 500);
        // activity.ShowSpinner();
        // Console.WriteLine("\n");
        // activity.ShowCountDown();

        // Breathe breathe = new Breathe("Breathe Activity", "Breathe in and out excercise", 3000);
        // breathe.Run();
       

        List<string> promptsList = new List<string>();
        promptsList.Add("--Think about a time you stood up for someone else.--");
        promptsList.Add("--Think of a time when you did something really challenging.--");
        promptsList.Add("--Think of a time when you helped someone in need.--");
        promptsList.Add("--Think of a time when you did something truly selfless.--");

        List<string> questionsList = new List<string>();
        questionsList.Add("Why was this experience meaningful to you?");
        questionsList.Add("Have you ever done anything like this before?");
        questionsList.Add("How did you get started?");
        questionsList.Add("How did you feel when it was complete?");
        questionsList.Add("What is your favourite thing about this experience?");
        questionsList.Add("What could you learn from this experience that applies to other situations");

        // Reflecting reflection = new Reflecting(promptsList, questionsList, "Reflecting");
        // reflection.Run();

        List<string> promptsList2 = new List<string>();
        promptsList2.Add("--Who are people that you appreciate?--");
        promptsList2.Add("--What are personal strengths of yours?--");
        promptsList2.Add("--Who are people that you have helped this week?--");
        promptsList2.Add("--When have you felt the Holy Ghost this month?--");
        promptsList2.Add("--Who are some of your personal heroes?--");

        // Listing listing = new Listing(5, promptsList2, "Listing", "", 5);
        // listing.Run();

        string userMenuChoice = "";
        while(userMenuChoice != "quit")
        {
             // Menu of Options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
    
            Console.Write("Select a choice from the menu: ");
            userMenuChoice = Console.ReadLine();

            if(userMenuChoice == "1")
            {
                Breathe breathe = new Breathe("Breathe");
                breathe.Run();
            }
            else if(userMenuChoice == "2")
            {
                 Reflecting reflection = new Reflecting(promptsList, questionsList, "Reflecting");
                 reflection.Run();
            }
            else if(userMenuChoice == "3")
            {
                Listing listing = new Listing(5, promptsList2, "Listing", "", 5);
                listing.Run();
            }
            else if(userMenuChoice.ToLower() == "4")
            {
                break;
            }
        }
    }
}