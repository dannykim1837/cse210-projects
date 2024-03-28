using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
        new Video("DJ Okawari - Flower Dance", "Bob42jh", 263),
        new Video("Joe Hisaishi - The Rain", "animefuefuki", 337),
        new Video("Kiss the rain - Yiruma", "Lulu", 253)
        new Video("Jon Schmidt & Steven Sharp Nelson - Love Story Meets Viva la Vida", "Vincent Fox", 484)
        };

        foreach (var video in videos)
        {
            video.Displayinfo();
        }


    }
}