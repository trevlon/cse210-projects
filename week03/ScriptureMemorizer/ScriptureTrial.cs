using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
public class ScriptureTrial
{
    private ReferenceTrial _reference;
    private List<WordsTrial> _text = new List<WordsTrial>();

    public ScriptureTrial(ReferenceTrial reference, string text)
    {
        _reference = reference;
        _text = new List<WordsTrial>();
        
        foreach(string word in text.Split(" "))
        {
            _text.Add(new WordsTrial(word));
        }
    }

    public void HideRandomWords(int numbersToHide)
    {
        int availableWords = 0;

        foreach(WordsTrial word in _text)
        {
            if(!word.IsHidden())
            {
                availableWords++;
            }
        }

         Random generateRandomNumber = new Random();
         if (numbersToHide > availableWords)
        {
            numbersToHide = _text.Count;
        }

         for(int i=0; i < numbersToHide; i++)
        {
        int index = generateRandomNumber.Next(_text.Count);
        // _text[index].Hide();
          
          while(_text[index].IsHidden() == true)
            {
               index = generateRandomNumber.Next(_text.Count);
            }
             _text[index].Hide();
        }
    } 

    public string GetDisplayText()
    {
        string combineText = "";
        foreach(WordsTrial word in _text)
        {
            combineText += word.GetDisplayText() + " ";
        }
         return _reference.GetDisplayText() + " " + combineText;
    }

    public bool IsCompletelyHidden()
    {
        foreach(WordsTrial word in _text)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }
         return true;
    }
}
