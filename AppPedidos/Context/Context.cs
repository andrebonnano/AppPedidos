using AppPedidos.Domain.Orders;
using AppPedidos.Domain.Products;
using AppPedidos.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace AppPedidos.Context
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
     
        
        public Context(DbContextOptions<Context> options) : base(options) { }

        
    }
}
