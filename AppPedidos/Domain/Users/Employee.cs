using AppPedidos.Enums;

namespace AppPedidos.Domain.Users
{
    public class Employee : User
    {
        public AccessCodes AccessCode { get; private set; }
        
        public Employee (string name, string email, string password) : base(name, email, password)
        {
            AccessCode = AccessCodes.user;
        }

        public void ChangeStatus(AccessCodes status, Guid userId)
        {
            AccessCode = status;
            AddEditData(userId);
        }

    }
}
