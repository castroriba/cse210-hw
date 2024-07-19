namespace OnlineOrdering
{
    public class Address
    {
        private string Street { get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private string Country { get; set; }

        public Address(string street, string city, string state, string country)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
        }

        public bool IsInUSA()
        {
            return Country.ToUpper() == "USA";
        }

        public string GetFormattedAddress()
        {
            return $"{Street}\n{City}, {State}\n{Country}";
        }
    }
}
