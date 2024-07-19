using System;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some addresses
            Address address1 = new Address("789 Maple St", "Hometown", "CA", "USA");
            Address address2 = new Address("101 Pine St", "Big City", "NY", "USA");
            Address address3 = new Address("202 Birch St", "Smallville", "TX", "USA");

            // Create events
            Event lecture = new Lecture("The Future of AI", "An in-depth look into AI advancements.", new DateTime(2024, 8, 12), new TimeSpan(18, 30, 0), address1, "Dr. Smith", 100);
            Event reception = new Reception("Summer Gala", "A fancy summer gathering.", new DateTime(2024, 8, 20), new TimeSpan(19, 0, 0), address2, "rsvp@example.com");
            Event outdoorGathering = new OutdoorGathering("Community Picnic", "A fun picnic for the community.", new DateTime(2024, 8, 25), new TimeSpan(11, 0, 0), address3, "Sunny with a chance of clouds");

            // Display event details
            DisplayEventDetails(lecture);
            DisplayEventDetails(reception);
            DisplayEventDetails(outdoorGathering);
        }

        static void DisplayEventDetails(Event evnt)
        {
            Console.WriteLine(evnt.GetFullDetails());
            Console.WriteLine(evnt.GetShortDescription());
            Console.WriteLine();
        }
    }
}
