namespace EventPlanning
{
    public class Lecture : Event
    {
        private string Speaker { get; set; }
        private int Capacity { get; set; }

        public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            Speaker = speaker;
            Capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
        }

        public override string GetShortDescription()
        {
            return $"Lecture: {Title} on {Date.ToShortDateString()}";
        }
    }
}
