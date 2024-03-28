using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
        new Video("DJ Okawari - Flower Dance", "Bob42jh", 263),
        new Video("Joe Hisaishi - The Rain", "animefuefuki", 337),
        new Video("Kiss the rain - Yiruma", "Lulu", 253),
        new Video("Jon Schmidt & Steven Sharp Nelson - Love Story Meets Viva la Vida", "Vincent Fox", 484)
        };

        Comment.AddCommentToVideo(videos[0], "classic1597", "I loved it so beautiful.  who watching this in 2015? i know i am :D");
        Comment.AddCommentToVideo(videos[0], "cyk7685", "I can't tell if this makes me feel happy or sad.");
        Comment.AddCommentToVideo(videos[0], "babylotion", "Who else just cried hearing this? awe man that's what you call beautiful");

        Comment.AddCommentToVideo(videos[1], "sykim1932", "This is the song that made me inspired to play the piano");
        Comment.AddCommentToVideo(videos[1], "Yiruma1211", "This Song takes me to a place that no other song can.......");
        Comment.AddCommentToVideo(videos[1], "Lanzylou", "My favorite pianists song..... since I was a teen.");

        Comment.AddCommentToVideo(videos[2], "theaba", "some people thought that the dislike button was dis I like button");
        Comment.AddCommentToVideo(videos[2], "kadack332", "its so peaceful and beautiful...i love this music...");
        Comment.AddCommentToVideo(videos[2], "rhenrhen", "I've been trying to find this for about two years now.");

        Comment.AddCommentToVideo(videos[3], "purplesparkle", "Tokyo looks amazing, I want to go there!");
        Comment.AddCommentToVideo(videos[3], "vcool29", "I wanna learn Piano  :(");
        Comment.AddCommentToVideo(videos[3], "znkiri", "i am a guy who always listens to hiphop and rnb,but this song moved me like never before.");

        foreach (var video in videos)
        {
            video.Displayinfo();
        }


    }
}