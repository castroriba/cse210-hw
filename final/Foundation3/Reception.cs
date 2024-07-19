namespace EventPlanning
{
    public class Reception : Event
    {
        private string RsvpEmail { get; set; }

        public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            RsvpEmail = rsvpEmail;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {RsvpEmail}";
        }

        public override string GetShortDescription()
        {
            return $"Reception: {Title} on {Date.ToShortDateString()}";
        }
    }
}
