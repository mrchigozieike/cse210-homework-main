using System;






public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Main St.", "Anytown", "CA");
        Address address2 = new Address("456 Broadway Ave.", "Anothercity", "WA");
        Address address3 = new Address("789 5th St.", "Yetanothercity", "NY");

        Lecture lecture = new Lecture("Title1", "Description1", new DateTime(2022, 2, 2, 14, 0, 0), address1, "Speaker1", 50);
        Reception reception = new Reception("Title2", "Description2", new DateTime(2022, 3, 3, 18, 0, 0), address2, "rsvpemail@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Title3", "Description3", new DateTime(2022, 4, 4, 10, 0, 0), address3, "Sunny");

        Console.WriteLine($"Lecture:\n{lecture.GetStandardDetails()}\n{lecture.GetFullDetails()}\n{lecture.GetShortDescription()}\n");
        Console.WriteLine($"Reception:\n{reception.GetStandardDetails()}\n{reception.GetFullDetails()}\n{reception.GetShortDescription()}\n");
        Console.WriteLine($"Outdoor Gathering:\n{outdoorGathering.GetStandardDetails()}\n{outdoorGathering.GetFullDetails()}\n{outdoorGathering.GetShortDescription()}\n");
    }
}

