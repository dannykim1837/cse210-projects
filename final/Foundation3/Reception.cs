class Reception : Event
{
    public Reception(string title, string description, DateTime date, DateTime time, Address address, string email)
        : base(title, description, date, time, address)
    {

    }

    public override void Detail()
    {
        System.Console.WriteLine($"Title : {title}");
        System.Console.WriteLine($"Description : {description}");
        System.Console.WriteLine($"Date : {date}");
        System.Console.WriteLine($"Time : {time}");
        System.Console.WriteLine($"Address : {address.getAddress()}");
        System.Console.WriteLine($"Email : {email}");
    }
}