using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppPedidos.EndPoints.Products
{
    public class ProductGet
    {
        public static string Template => "/products/{id:guid}";
        public static string[] Methods => new string[] { HttpMethods.Get.ToString() };
        public static Delegate Handle => Action;

        public static async Task<IResult> Action([FromRoute] Guid id, Context.Context context)
        {
            var products = context.Product.Include(p => p.Name).Where(p => p.Id == id);
            var results = products.Select(p => new ProductResponse(p.Name, p.Description, p.Price, p.IsActive));
            return Results.Ok(results);
        }
    }
}
