class Video
{
    public void Displayinfo()
    {
        System.Console.WriteLine($"Title : {title}");
        System.Console.WriteLine($"Author : {author}");
        System.Console.WriteLine($"Duration : {duration} seconds");
        System.Console.WriteLine($"Comments : {GetComments()}");
    }
}