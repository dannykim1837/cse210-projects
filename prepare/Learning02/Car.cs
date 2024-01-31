class Car {
    public string model;
    public string make;
    public int year;
    public int milesPerGallon;
    public int gallons;
    public Person owner;

    public Car(string make, string model, int milesPerGallon, int gallons){
        this.model = model;
        this.make = make;
        this.milesPerGallon = milesPerGallon;
        this. gallons = gallons;
    }
    // 프로그램.cs에 이렇게 입력하면 됨.
    // var car = new Car("Honda", "Civic", 10, 30);

    public int TotalRange()
    {
        return gallons * milesPerGallon;
    }

    public void Display() {
        System.Console.WriteLine($"{make} {model} {year} {owner.DisplayString()} : totalRange = {TotalRange()}");
    }
}

class Person{
    public string name;
    public string phone;

    public string DisplayString() {
        return $"{name} {phone}";
    }
}