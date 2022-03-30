using AppPedidos.Domain.Products;

namespace AppPedidos.EndPoints.Products
{
    public class ProductPost
    {
        public static string Template => "/products";
        public static string[] Methods => new string[] { HttpMethods.Post.ToString() };
        public static Delegate Handle => Action;

        public static Task<IResult> Action(ProductRequest productRequest, HttpContext http, Context.Context context)
        {
            Product product = new(productRequest.Name, productRequest.Description, productRequest.Price);
            return (Task<IResult>)Results.Created("/products/" + product.Id, product.Id);
        }
    }
}
