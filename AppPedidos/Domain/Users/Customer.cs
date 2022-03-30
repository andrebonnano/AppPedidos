namespace AppPedidos.Domain.Users
{
    public class Customer : User
    {
        public string Cpf { get; private set; }
        public string Phone { get; private set; }
        public List<Address> Adresses { get; private set; } = new List<Address>();


        public Customer(string name, string email, string password, string cpf, string phone) : base (name, email, password)
        {            
            Cpf = cpf;
            Phone = phone;
        }

        public void AddAdress(Address address, Guid userId)
        {
            Adresses.Add(address);
            AddEditData(userId);
        }

        public List<Address> GetAddresses()
        {
            return Adresses;
        }
    }
}
