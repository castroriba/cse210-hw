using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of videos
            var videos = new List<Video>();

            // Create first video and add comments
            var video1 = new Video("Amazing Tech Review", "TechGuru", 300);
            video1.AddComment(new Comment("Alice", "Great insights!"));
            video1.AddComment(new Comment("Bob", "Thanks for the review."));
            video1.AddComment(new Comment("Charlie", "Very informative."));
            videos.Add(video1);

            // Create second video and add comments
            var video2 = new Video("Cooking with Chef Mike", "ChefMike", 180);
            video2.AddComment(new Comment("Diana", "Delicious recipe!"));
            video2.AddComment(new Comment("Evan", "Can’t wait to try this."));
            video2.AddComment(new Comment("Fiona", "The cooking tips are helpful."));
            videos.Add(video2);

            // Create third video and add comments
            var video3 = new Video("Travel Vlog: Paris", "TravelBlogger", 360);
            video3.AddComment(new Comment("George", "Beautiful footage!"));
            video3.AddComment(new Comment("Hannah", "Paris looks amazing."));
            video3.AddComment(new Comment("Ian", "Great travel tips."));
            videos.Add(video3);

            // Display information for each video
            foreach (var video in videos)
            {
                video.Display();
                Console.WriteLine();
            }
        }
    }
}
