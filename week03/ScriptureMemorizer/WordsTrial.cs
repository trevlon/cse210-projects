using System.Runtime.CompilerServices;

public class WordsTrial
{
    private string _text;
    private bool hiddenText = false;

    public WordsTrial(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        // if(hiddenText == true)
        // {
        //   Console.WriteLine(_text.Replace(_text, "_"));
        // }
        hiddenText = true;
    }

    public void Show()
    {
        // if(hiddenText == false)
        // {
        //   Console.WriteLine(_text);
        // }
        hiddenText = true;
    }
    // public string HiddenText()
    // {
    //      if(hiddenText == true)
    //     {
    //        return new string('_', _text.Length);
    //     }
    //     else
    //     {
    //         return _text;
    //     }
    // }

    public bool IsHidden()
    {
        return hiddenText;
    }

    public string GetDisplayText()
    {
           if(hiddenText)
        {
           return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}