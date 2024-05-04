using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        HotelPlan inahHotel = new HotelPlan();
        inahHotel._receptionHall = "Main Hall";
        inahHotel._room1 = "Cambodia Room";
        inahHotel._room2 = "Guest Room";

        // Console.WriteLine(inahHotel._room2);
        bool isOpen = inahHotel.OpenDoor(inahHotel._room1);
        Console.WriteLine(isOpen);
    }
}