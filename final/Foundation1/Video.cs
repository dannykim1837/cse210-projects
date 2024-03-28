class Video
{
    public string title;
    public string authou;
    public int length;
    
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void Displayinfo()
    {
        System.Console.WriteLine($"Title : {title}");
        System.Console.WriteLine($"Author : {author}");
        System.Console.WriteLine($"Duration : {length} seconds");
        System.Console.WriteLine($"Comments : {GetNumberOfComments()()}");
    }
}