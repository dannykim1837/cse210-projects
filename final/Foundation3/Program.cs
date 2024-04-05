using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureaddress = new Address("101 E Viking St", "Rexburg", "ID", 83460);
        Lecture lecture = new Lecture("Do schools kill creativity?", "Sir Ken Robinson makes an entertaining and profoundly moving case for creating an education system that nurtures (rather than undermines) creativity",
        DateTime.Now, "12:00 AP", lectureaddress, "Ken Robinson", 100);
        Console.Clear();
        System.Console.WriteLine("-----------------------------");
        lecture.Detail();
        System.Console.WriteLine("-----------------------------");


        Address outdooraddress = new Address("311 S 1st W", "Rexburg", "ID", 83460);
        OutdoorGather outdoorGather = new OutdoorGather("Pickel Ball", "Play Together!", DateTime.Now, "10:00 AM", outdooraddress, "Sunny");
        outdoorGather.Detail();
        System.Console.WriteLine("-----------------------------");

        Address receptionaddress = new Address("BCTR, 50 W Viking St BYU", "Rexburg", "ID", 83460);
        Reception reception = new Reception("Church", "Sacrement Meeting", DateTime.Now, "2:00 PM", receptionaddress, "church@lds.org");
        reception.Detail();
        System.Console.WriteLine("-----------------------------");
    }
}