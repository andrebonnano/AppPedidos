namespace AppPedidos.EndPoints.Products
{
    public record ProductRequest(string Name, string Description, double Price, bool IsActive);
}
