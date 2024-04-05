class Event
{
    string Title;
    string Description;
    DateTime Date;
    DateTime Time;
    Address address;
    string Name;
    string Email;

    public Event(string title, string description, DateTime date, DateTime time, Address address, string name, string email)
    {
        this.Title = title;
        this.Description = description;
        this.Date = date;
        this.Time = time;
        this.Address = address;
        this.Name = name;
        this.Email = email;
    }

    public void Detail();
}