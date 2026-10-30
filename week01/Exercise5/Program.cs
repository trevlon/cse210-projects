using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResults(userName, squared);

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favourite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResults(string name, int squared)
        {
            Console.WriteLine($"Brother {name}, the squared of your number is {squared}");
        }
    }
}