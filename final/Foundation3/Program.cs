using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureaddress = new Address("101 E Viking St", "Rexburg", "ID", 83460);
        Lecture lecture = new Lecture();

        Address outdooraddress = new Address();
        OutdoorGather outdoorGather = new OutdoorGather();

        Address receptionaddress = new Address();
        Reception reception = new Reception();
    }
}