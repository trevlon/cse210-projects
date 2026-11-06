using System.Collections.Generic;
using Microsoft.VisualBasic;
public class RandomPrompt
{
  public List<string> myPrompts = new List<string>
  {
       "What was your favourite part of today? ",

       "Who did you enjoy spending time with? ",

       "How was work or school today? ",

       "Did you have any challenges today, if yes, how did you manage it? ",

       "How was your general mood today? "
    };
    
    public string GetRandomPrompts()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(myPrompts.Count);

        return myPrompts[index];
    }
}