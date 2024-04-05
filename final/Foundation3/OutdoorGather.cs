public class OutdoorGather : Event
{
    string Weather;

    public OutdoorGather(string title, string description, DateTime date, string time, Address address, string weather)
        : base(title, description, date, time, address, null)
    {
        this.Weather = weather;
    }
    public override void Detail()
    {
        System.Console.WriteLine($"Title : {Title}");
        System.Console.WriteLine($"Description : {Description}");
        System.Console.WriteLine($"Date : {Date}");
        System.Console.WriteLine($"Time : {Time}");
        System.Console.WriteLine($"Address : {address.getAddress()}");
        System.Console.WriteLine($"Weahter : {Weather}");
    }
}