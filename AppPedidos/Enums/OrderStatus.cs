namespace AppPedidos.Enums
{
    public enum OrderStatus : int
    {
        Created = 0,
        Pending = 1,
        Processing = 2,
        Awaiting = 3,
        Authorized = 4,
        Unauthorized = 5,
        Completed = 6,
        Cancelled = 7
    }
}
