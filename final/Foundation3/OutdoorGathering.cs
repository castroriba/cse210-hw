namespace EventPlanning
{
    public class OutdoorGathering : Event
    {
        private string WeatherForecast { get; set; }

        public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            WeatherForecast = weatherForecast;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
        }

        public override string GetShortDescription()
        {
            return $"Outdoor Gathering: {Title} on {Date.ToShortDateString()}";
        }
    }
}
