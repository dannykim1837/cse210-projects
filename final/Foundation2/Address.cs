class address
{
    string state;
    string city;
    string street;
    string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool intheUSA()
    {
        return country == "USA";
    }

    public fullAddress()
    {
        return ($"{street}, {city}, {state}, {country}")
    }
}