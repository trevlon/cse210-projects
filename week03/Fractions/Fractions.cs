// class name Fractions
using System.Reflection.Emit;

public class Fractions
{
    // Member variables set to private
    private int _top;
    private int _bottom;

    // Constructor to set default values to _top and _bottom
    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor set _top to be equals to parameter "wholeNumber", set _bottom to default value
    public Fractions(int wholeNUmber)
    {
        _top = wholeNUmber;
        _bottom = 1;
    }

    // Constructor set the member variables to parameters top and bottom
    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Method to retrieve _top variable
    public int GetTop()
    {
        return _top;
    }

    // Method to set _top variable to parameter top
    public void SetTop(int top)
    {
        _top = top;
    }

    // Method to retrieve _bottom variable
    public int GetBottom()
    {
        return _bottom;
    }

    // Method to set _bottom variable to parameter bottom
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Method to perform text output using the values that would be entered in Program.cs
    public string GetFractionString()
    {
        string message = $"{_top}/{_bottom}";
        return message;  
    }

    // Method to divide the values entered in the parameter inside Program.cs
    public double GetDecimalValue()
    {
        return (double) _top / (double) _bottom;
    }
}