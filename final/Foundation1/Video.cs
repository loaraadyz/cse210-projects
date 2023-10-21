public class Video
{
    public string _title;
    public string _author;
    public double _length;

    public Video(string author, string title, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    List<Comment> _comments = new List<Comment>();

    public int CountComments()
    {
        int count = _comments.Count();
        return count;
    }

    public void ListComment(Comment comment)
    {
        _comments.Add(comment);
    }


    public void DisplayInfo()
    {
        int countComment = CountComments();
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length}");
        Console.WriteLine($"Number of Comments:{countComment}\nList of Comments:");
        int counter = 1;
        foreach (Comment comment in _comments)
        {
            Console.Write($"{counter}.");
            comment.DisplayInfo();
            counter++;
        }
    }

}