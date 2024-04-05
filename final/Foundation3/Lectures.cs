class Lecture : Event
{
    string Speaker;
    int Capacity;

    public Lecture(string title, string description, DateTime date, DateTime time, Address address, string name, string email, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.Speaker = speaker;
        this.Capacity = capacity;
    }

    public override void Detail()
    {
        System.Console.WriteLine($"Title : {title}");
        System.Console.WriteLine($"Description : {description}");
        System.Console.WriteLine($"Date : {date}");
        System.Console.WriteLine($"Time : {time}");
        System.Console.WriteLine($"Address : {address.getAddress()}");
        System.Console.WriteLine($"Speaker : {speaker}");
        System.Console.WriteLine($"Capacity : {capacity}");
    }
}