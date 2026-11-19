using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        // Video 1
        Video vidInfo = new Video("Male Leather Jackets", "Kelvin James", 120);
        
        Comment name = new Comment("James", "Great videos, might get one for my cousin");
    
        // Video 2
        Video vidInfo2 = new Video("Women Leather Jackets", "Ella Bailey", 600);
        
        Comment name2 = new Comment("philipians1234saved", "Are there jackets with different colors instead of black?");
        
        // Video 3
        Video vidInfo3 = new Video("Children Leather Jackets", "Emily Grace", 240);
        
        Comment name3 = new Comment("BigWorldCity", "Are teenagers included or nah?");
        
        // Use the AddComment() function to add the comment from the new object made from the Video class in Program.cs
        vidInfo.AddComment(name);
        vidInfo2.AddComment(name2);
        vidInfo3.AddComment(name3);

        // List object for video, adding vidinfo in the list so it will have data for the loop
        List<Video> videoList = new List<Video>();
        videoList.Add(vidInfo);
        videoList.Add(vidInfo2);
        videoList.Add(vidInfo3);

        // List object for comments, adding name in the list so it will have data for the loop
        List<Comment> commentList = new List<Comment>();
        commentList.Add(name);
        commentList.Add(name2);
        commentList.Add(name3);
        
        // Uses the Display method from Video.cs to display all the video information and also method to display the number
        // of comments for each video
        foreach(Video video in videoList)
        {
            Console.WriteLine(video.Display());
            Console.WriteLine($"Number of Comments: {vidInfo.DisplayNumberOfComments()}");

            Console.WriteLine();
           
        }

        // Uses DisplayNumberOfComments method from Video.cs and add up all the comments to get the total number of comments
        foreach(Comment comment in commentList)
        {
            int totalComments = 0;
             
            totalComments += vidInfo.DisplayNumberOfComments() + vidInfo2.DisplayNumberOfComments() + vidInfo3.DisplayNumberOfComments();
            Console.WriteLine($"Total Comments: {totalComments}");
            Console.WriteLine();
            break;
        }
            
            // Displaying the actual comments
            Console.WriteLine(name.Display());
            Console.WriteLine();
            Console.WriteLine(name2.Display());
            Console.WriteLine();
            Console.WriteLine(name3.Display());
    }
}