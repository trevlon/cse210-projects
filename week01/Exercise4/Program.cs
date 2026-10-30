using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            int sum = 0;
            double average = 0;
            int userNumber = 1;
            double count = 0;
            int largest = 0;
            while (userNumber != 0)
            {
            // Asking the user for a number
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            // To break loop
            // This is to ensure that zero does not get added to the count
            if (userNumber == 0)
            {
                break;
            }

            // Appending or adding the numbers to a list
            List <int> number = new List <int>();
            number.Add(userNumber);

            // Calculate the total of the numbers the user entered
            sum += userNumber;

            // calculate the amount of times the user enters a number
            count ++;
            // Calculating the average
            average = (sum) / count;

            if (userNumber > largest)
            {
                largest = userNumber;
            }
            }
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The count is: {average}");
            Console.WriteLine($"The largest number is: {largest}");
    }
}