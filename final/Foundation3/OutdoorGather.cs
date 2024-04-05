class OutdoorGather : Event
{
    string Weather;

    public OutdoorGather(string title, string description, DateTime date, DateTime time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        this.Weather = weather;
    }
    public override void Detail()
    {
        System.Console.WriteLine($"Title : {title}");
        System.Console.WriteLine($"Description : {description}");
        System.Console.WriteLine($"Date : {date}");
        System.Console.WriteLine($"Time : {time}");
        System.Console.WriteLine($"Address : {address.getAddress()}");
        System.Console.WriteLine($"Weahter : {weather}");
    }
}