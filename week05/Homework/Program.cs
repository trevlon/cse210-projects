using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment = new Assignment("James", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();

        MathAssignment math = new MathAssignment("Robeto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        
        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetStudentTitle());
    }
}