class Address
{
    string State;
    string City;
    string Street;
    int ZipCode;

    public Address(string street, string city, string state, int zipCode)
    {
        this.State = state;
        this.City = city;
        this.Street = street;
        this.ZipCode = zipCode;
    }

    public string getAddress()
    {
        return ($"{state}, {city}, {street}, {zipCode}")
    }

}