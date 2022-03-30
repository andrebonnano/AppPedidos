namespace AppPedidos.Domain.Users
{
    public class Address
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Alias { get; private set; }
        public string Street { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }

        public Address(string alias, string street, string complement, string district, string city, string state, string country)
        {
            Alias = alias;
            Street = street;
            Complement = complement;
            District = district;
            City = city;
            State = state;
            Country = country;
        }
    }
}
