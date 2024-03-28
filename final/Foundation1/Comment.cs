class Comment
{
    public string Name;
    public string Text;

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    public static void AddCommentToVideo(Video video, string name, string text)
    {
        video.AddComment(new Comment(name, text));
    }
}