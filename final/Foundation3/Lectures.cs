public class Lecture : Event
{
    public string Speaker;
    public int Capacity;

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address, null)
    {
        this.Speaker = speaker;
        this.Capacity = capacity;
    }

    public override void Detail()
    {
        System.Console.WriteLine($"Title : {Title}");
        System.Console.WriteLine($"Description : {Description}");
        System.Console.WriteLine($"Date : {Date}");
        System.Console.WriteLine($"Time : {Time}");
        System.Console.WriteLine($"Address : {address.getAddress()}");
        System.Console.WriteLine($"Speaker : {Speaker}");
        System.Console.WriteLine($"Capacity : {Capacity}");
    }
}