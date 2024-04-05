public abstract class Event
{
    public string Title;
    public string Description;
    public DateTime Date;
    public string Time;
    public Address address;
    public string Email;

    public Event(string title, string description, DateTime date, string time, Address address, string email)
    {
        this.Title = title;
        this.Description = description;
        this.Date = date;
        this.Time = time;
        this.address = address;
        this.Email = email;
    }

    public abstract void Detail();
}