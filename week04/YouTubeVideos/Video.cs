using System.Collections.Generic;
using System.Numerics;
public class Video
{
    // Member variables
    public string _title;
    public string _author;
    public double _length;

    public List<Comment> _comment = new List<Comment>();
    public List<Video> _video = new List<Video>();

    // Constructor
    public Video()
    {
        _title = "";
        _author = "";
        _length = 0;
    }

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
  
    // A method to return the video information
    public string Display()
    {
        return $"Video Title: {_title}, \nAuthor: {_author} \nLength in seconds: {_length}";
    }

    // A method to add user comments to the List<comment>
    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public void AddVideo(Video video)
    {
        _video.Add(video);
    }
    
    // Return the total amount of comments
    public int DisplayNumberOfComments()
    {
         return _comment.Count();
    }
}