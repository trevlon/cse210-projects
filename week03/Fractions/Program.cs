using System;
using System.Net;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fractions number = new Fractions();
        Console.WriteLine(number.GetFractionString());
        Console.WriteLine(number.GetDecimalValue());

        Fractions number2 = new Fractions(5);
        Console.WriteLine(number2.GetFractionString());
        Console.WriteLine(number2.GetDecimalValue());

        Fractions number3 = new Fractions(3,4);
        Console.WriteLine(number3.GetFractionString());
        Console.WriteLine(number3.GetDecimalValue());

        Fractions number4 = new Fractions(1, 3);
        Console.WriteLine(number4.GetFractionString());
        Console.WriteLine(number4.GetDecimalValue());

    }
}