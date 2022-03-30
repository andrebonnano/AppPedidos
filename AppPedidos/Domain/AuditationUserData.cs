namespace AppPedidos.Domain
{
    public class AuditationUserData
    {
        public Guid Id { get; set; }
        public Guid UserId { get;  set; }
        public DateTime Moment { get;  set; }

        public AuditationUserData()
        {
        }

        public AuditationUserData(Guid userId, DateTime moment)
        {
            UserId = userId;
            Moment = moment;
        }
    }
}
