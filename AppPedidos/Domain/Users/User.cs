using AppPedidos.Domain;

namespace AppPedidos.Domain.Users
{
    public class User : Auditation
    {

        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool Active { get; private set; }
        public List<DateTime> LoginCount { get; private set; } = new List<DateTime>();
        public string Password { get; private set; }


        public User(string name, string email, string password) : base()
        {
            Name = name;
            Email = email;
            Active = true;
            Password = password;
        }

        public void AddLoginCount()
        {
            DateTime count = DateTime.Now;
            LoginCount.Add(count);
        }

        public void Desctivate()
        {
            Active = false;
        }
    }



}
