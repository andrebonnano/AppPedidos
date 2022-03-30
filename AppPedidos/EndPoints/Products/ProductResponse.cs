namespace AppPedidos.EndPoints.Products
{
    public record ProductResponse(string name, string description, double price, bool isActive);
}
