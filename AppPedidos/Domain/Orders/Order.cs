using AppPedidos.Domain.Products;
using AppPedidos.Enums;

namespace AppPedidos.Domain.Orders
{
    public class Order : Auditation
    {
        public DateTime Date { get; private set; }
        public Guid Customer { get; private set; }
        public Guid AddressId { get; private set; }
        public List<OrderItem> Items { get; private set; }
        public OrderStatus Status { get; private set; }

        public Order(Guid customer, Guid addressId)
        {
            Customer = customer;
            AddressId = addressId;
            Status = OrderStatus.Created;
            Date = DateTime.Now;
            Items = new List<OrderItem>();
        }

        public void AddItem(Product product, int quantity)
        {
            OrderItem item = new(product, quantity);
            Items.Add(item);

            Edit.Add(new AuditationUserData(Id, DateTime.Now));
        }

        public List<OrderItem> GetAllProducts()
        {
            return Items;
        }

        public double GetTotalPrice()
        {
            double sum = 0;
            foreach (var item in Items)
            {
                sum += item.Product.Price;
            }
            return sum;
        }
    }
}
