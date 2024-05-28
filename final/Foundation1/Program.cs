using System;

public class Program
{
    public static void Main()
    {
        // Create video instances
        var video1 = new Video("C# Tutorial", "John Etta", 3600);
        var video2 = new Video("Cooking Basics", "Jane Akpolo", 1800);
        var video3 = new Video("Travel Vlog", "Alex Omini", 2400);

        // Add comments to video1
        video1.AddComment(new Comment("Smith", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Obeten", "I learned a lot."));

        // Add comments to video2
        video2.AddComment(new Comment("Emma", "Can't wait to try these recipes."));
        video2.AddComment(new Comment("Kayena", "Yummy!"));
        video2.AddComment(new Comment("Ameaka", "This is amazing."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Nice places!"));
        video3.AddComment(new Comment("Victor", "Beautiful scenery."));
        video3.AddComment(new Comment("Iyang", "I want to visit these places."));

        // Store videos in a list
        var videos = new List<Video> { video1, video2, video3 };

        // Display information about each video and its comments
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}