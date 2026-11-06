using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        string option = "";

         while (option != "5")
        {  
        Console.WriteLine("Hello World! This is the Journal Project.");
      
        Console.WriteLine("Please select one of the following choices:");
        myJournal.JournalChoices();

        Console.WriteLine("Which option would you like to choose? ");
        option = Console.ReadLine();

        if (option == "1")
        {
      
            string date = DateTime.Now.ToShortDateString();
            RandomPrompt randomPrompt = new RandomPrompt();
            string prompt = randomPrompt.GetRandomPrompts();
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            Entry myEntry = new Entry(date, prompt, response);

            myJournal.AddEntry(myEntry);
        }
        else if (option == "2")
        {
           myJournal.DisplayAllEntries();
           Console.WriteLine();
        }
        else if (option == "3")
            {
                Console.WriteLine("Please enter a file name to save entry:");
                string fileName = Console.ReadLine();

                myJournal.SaveToFile(fileName);
            }
        else if (option == "4")
            {
                Console.WriteLine("Please enter existing file name:");
                string fileName = Console.ReadLine();

                myJournal.LoadFromFile(fileName);
            }
        else if (option == "5")
            {
                Console.WriteLine("Journal closed");
                break;
            }
        
    }
}
}