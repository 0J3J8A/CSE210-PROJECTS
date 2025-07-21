using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create first video and add comments
        Video v_1 = new Video("How to program in C#", "John Smith", 600);
        v_1.AddComment(new Comment("Anna Garcia", "Excellent tutorial!"));
        v_1.AddComment(new Comment("Charles Lopez", "Very well explained."));
        v_1.AddComment(new Comment("Maria Rodriguez", "Thanks for sharing."));
        videos.Add(v_1);

        // Create second video and add comments
        Video v_2 = new Video("Learn Python in 10 minutes", "Laura Johnson", 720);
        v_2.AddComment(new Comment("Peter Sanchez", "Good summary."));
        v_2.AddComment(new Comment("Sophia Hernandez", "Helped me a lot."));
        v_2.AddComment(new Comment("George Diaz", "Where's the advanced part?"));
        v_2.AddComment(new Comment("Lucy Fernandez", "Perfect for beginners."));
        videos.Add(v_2);

        // Create third video and add comments
        Video v_3 = new Video("Introduction to SQL", "Carlos Gomez", 480);
        v_3.AddComment(new Comment("Michael Torres", "Very clear."));
        v_3.AddComment(new Comment("Helen Ruiz", "Needed more examples."));
        v_3.AddComment(new Comment("David Jimenez", "Exactly what I needed."));
        videos.Add(v_3);

        // Create fourth video and add comments
        Video v_4 = new Video("HTML Basics for Beginners", "Emily Wilson", 540);
        v_4.AddComment(new Comment("Robert Chen", "Great introduction to HTML tags!"));
        v_4.AddComment(new Comment("Sarah Johnson", "Finally understand div vs span."));
        v_4.AddComment(new Comment("Thomas Lee", "Could you make one about HTML5?"));
        v_4.AddComment(new Comment("Jennifer Park", "Perfect pacing for complete beginners."));
        videos.Add(v_4);

        // Display Information
        foreach (Video i in videos)
        {
            Console.WriteLine($"Title: {i.GetTitle()}");
            Console.WriteLine($"Author: {i.GetAuthor()}");
            Console.WriteLine($"Length: {i.GetLengthSeconds()} seconds");
            Console.WriteLine($"Number of comments: {i.GetNumberOfComments()}");

            Console.WriteLine("Comments:");

            Console.WriteLine();

            foreach (Comment comment in i.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommentPerson()}: {comment.GetCommentText()}");
            }

            Console.WriteLine(); // Space between videos
            Console.WriteLine(); // Space between videos (DOUBLE SPACE)
        }
    }
}