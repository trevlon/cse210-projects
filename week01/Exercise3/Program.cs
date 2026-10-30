using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random(); // Makes a random number generator
        int number = randomGenerator.Next(1,100); // Range from 1 to 100
    
        int guess = 0;
        
        while (guess != number)
        {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (guess > number)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < number)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
        }
    }
}

