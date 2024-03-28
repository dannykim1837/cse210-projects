class Comment
{
    public string Name;
    public string Text;

    List<string> names= new List<string>
    {
        "classic1597",
        "cyk7685",
        "babylotion",
        "sykim1932"
    };

    List<string> comments= new List<string>
    {
        "I loved it so beautiful.  who watching this in 2015? i know i am :D",
        "I can't tell if this makes me feel happy or sad.",
        "Who else just cried hearing this? awe man that's what you call beautiful",
        "This is the song that made me inspired to play the piano"
    };

    public Comment()
    {
        Random random = new Random();
        int randomIndex = random.Next(names.Count);
        name = names[randomIndex];
        comment= comments[random.Next(comments.Count)];
    }

    public static void AddCommentToVideo(Video video, string Name, string text)
    {
        video.AddComment(new Comment(name, text));
    }
}