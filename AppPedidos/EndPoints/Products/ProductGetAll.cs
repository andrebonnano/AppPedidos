using Microsoft.EntityFrameworkCore;

namespace AppPedidos.EndPoints.Products
{
    public class ProductGetAll
    {
        public static string Template => "/products";
        public static string[] Methods => new string[] { HttpMethods.Get.ToString() };
        public static Delegate Handle => Action;

        public static async Task<IResult> Action(Context.Context context)
        {
            var products = context.Product.Include(p => p.Name).ToList();
            var results = products.Select(p => new ProductResponse(p.Name, p.Description, p.Price, p.IsActive));
            return Results.Ok(results);
        }
    }
}
