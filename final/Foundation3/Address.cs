public class Address
{
    private string State;
    private string City;
    private string Street;
    private int ZipCode;

    public Address(string street, string city, string state, int zipCode)
    {
        this.State = state;
        this.City = city;
        this.Street = street;
        this.ZipCode = zipCode;
    }

    public string getAddress()
    {
        return $"{Street}, {City}, {State} {ZipCode}";
    }

}