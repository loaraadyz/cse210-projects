using System;

class Program
{
    
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Yasmin", "How to Earn Money", 10);

        Comment v1comment1 = new Comment("April", "This content is helpful.");
        Comment v1comment2 = new Comment("Dwight", "Great business idea.");
        Comment v1comment3 = new Comment("Evan", "How much money should I start with?");

        video1.ListComment(v1comment1);
        video1.ListComment(v1comment2);
        video1.ListComment(v1comment3);

        videos.Add(video1);

        Video video2 = new Video("Adyz", "Improve Time Management", 10);

        Comment v2comment1 = new Comment("April", "I really need this.");
        Comment v2comment2 = new Comment("Dwight", "Planning ahead is really effective");
        Comment v2comment3 = new Comment("Evan", "Nice Mobile App to manage my time");

        video2.ListComment(v2comment1);
        video2.ListComment(v2comment2);
        video2.ListComment(v2comment3);

        videos.Add(video2);

        Video video3 = new Video("Peter", "Finding Faith in Christ", 10);

        Comment v3comment1 = new Comment("April", "I know that Jesus Christ lives.");
        Comment v3comment2 = new Comment("Dwight", "Praying keeps me moving forward");
        Comment v3comment3 = new Comment("Evan", "I should read my scriptures regularly, thanks.");

        video3.ListComment(v3comment1);
        video3.ListComment(v3comment2);
        video3.ListComment(v3comment3);

        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }        
    }
}