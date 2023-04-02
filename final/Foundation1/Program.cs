using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to hold our videos
        List<Video> videos = new List<Video>();

        // Create some videos and add them to the list
        Video video1 = new Video("Cats vs. Dogs", "Pet Lovers", 300);
        video1.AddComment("John", "This video is hilarious!");
        video1.AddComment("Jane", "I love cats!");
        video1.AddComment("Bob", "Dogs are better than cats.");
        videos.Add(video1);

        Video video2 = new Video("Cooking with Chef Alex", "Food Network", 600);
        video2.AddComment("Alice", "This recipe looks amazing!");
        video2.AddComment("Bob", "I've tried this recipe before and it's delicious!");
        video2.AddComment("Charlie", "I can't wait to try this myself.");
        videos.Add(video2);

        Video video3 = new Video("Top 10 Anime of All Time", "Anime Fans United", 900);
        video3.AddComment("Megan", "Great choices! I love all of these anime.");
        video3.AddComment("Josh", "I haven't seen all of these yet, but I'll definitely check them out.");
        video3.AddComment("Emily", "I don't agree with the rankings, but these are all great anime.");
        videos.Add(video3);

        // Display information about each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: {0}", video.Title);
            Console.WriteLine("Author: {0}", video.Author);
            Console.WriteLine("Length (seconds): {0}", video.Length);
            Console.WriteLine("Number of comments: {0}", video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("{0}: {1}", comment.Name, comment.Text);
            }

            Console.WriteLine();
            // Add an empty line between videos
        }

        // Wait for the user to press a key before exiting
        Console.ReadKey();
    }
}


