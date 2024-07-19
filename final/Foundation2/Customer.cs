namespace OnlineOrdering
{
    public class Customer
    {
        public string Name { get; private set; }
        private Address CustomerAddress { get; set; }

        public Customer(string name, Address address)
        {
            Name = name;
            CustomerAddress = address;
        }

        public bool LivesInUSA()
        {
            return CustomerAddress.IsInUSA();
        }

        public Address GetAddress()
        {
            return CustomerAddress;
        }
    }
}
