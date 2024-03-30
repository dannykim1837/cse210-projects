class Customer{

    private string name;
    
    private Address address;


    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string GetName()
    {
        return name;
    }
    
    public bool isinUSA()
    {
        return address.intheUSA();
    }

    public Address GetAddress()
    {
        return address;
    }
}