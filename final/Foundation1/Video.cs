class Video
{
    public string Title;
    public string Author;
    public int Length;
    List<Comment> comments = new List<Comment>();
    
    

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }
    
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void Displayinfo()
    {
        Console.Clear();
        System.Console.WriteLine("");
        System.Console.WriteLine($"Title : {Title}");
        System.Console.WriteLine($"Author : {Author}");
        System.Console.WriteLine($"Duration : {Length} seconds");
        System.Console.WriteLine($"Comments : {GetNumberOfComments()}");

        System.Console.WriteLine("Comments:");
        foreach (var comment in comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
    }
    
}