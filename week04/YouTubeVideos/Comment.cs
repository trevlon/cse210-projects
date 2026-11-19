using System.ComponentModel.DataAnnotations;

public class Comment
{
    // Member variables
   public string _name;
   public string _text;

  // Constructor
   public Comment()
    {
        _name = "";
        _text = "";
    }

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Method to return the name and comment from viewer
    public string Display()
    {
        return $"Name of commenter: {_name} \nComment: {_text}";
    }
}