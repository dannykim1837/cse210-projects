public class Reception : Event
{
    public Reception(string title, string description, DateTime date, string time, Address address, string email)
        : base(title, description, date, time, address, null)
    {
        this.Email = email;
    }

    public override void Detail()
    {
        System.Console.WriteLine($"Title : {Title}");
        System.Console.WriteLine($"Description : {Description}");
        System.Console.WriteLine($"Date : {Date}");
        System.Console.WriteLine($"Time : {Time}");
        System.Console.WriteLine($"Address : {address.getAddress()}");
        System.Console.WriteLine($"Email : {Email}");
    }
}