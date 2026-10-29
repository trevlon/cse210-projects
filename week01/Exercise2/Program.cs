using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise2 Project.");
        string letter = "";
        Console.Write("What is your grade percentage? ");
        int percentage = int.Parse(Console.ReadLine());

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congragulations you have passed this course");
        }
        else if (percentage < 70)
        {
            Console.WriteLine("You have failed the course, but don't give up, try again next semester");
        }
    }
}