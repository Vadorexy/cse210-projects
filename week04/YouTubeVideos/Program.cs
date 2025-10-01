using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Videos created
        Video video1 = new Video("Introduction to C#", "freeCodeCamp", 850);
        video1.AddComment(new Comment("Alice", "Great video, thanks!"));
        video1.AddComment(new Comment("Bob", "Very helpful, I finally understand classes."));
        video1.AddComment(new Comment("Chidi", "Could you explain interfaces next?"));

        Video video2 = new Video("Funny Cats Compilation", "CatWorld", 300);
        video2.AddComment(new Comment("Dubby", "This made my day 😂"));
        video2.AddComment(new Comment("Ella", "I love cats so much!"));
        video2.AddComment(new Comment("Frank", "Where’s part 2?"));

        Video video3 = new Video("Cooking Like a Pro", "HildaBaci1", 450);
        video3.AddComment(new Comment("Grace", "Wow, turned out delicious!"));
        video3.AddComment(new Comment("Henry", "Could you do a lasagna video?"));
        video3.AddComment(new Comment("Vivian", "I tried this recipe yesterday!"));

        // Store videos in list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}