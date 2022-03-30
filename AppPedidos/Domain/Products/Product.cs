namespace AppPedidos.Domain.Products
{
    public class Product : Auditation
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
        public bool IsActive { get; private set; }

        public Product(string name, string description, double price) : base()
        {
            Name = name;
            Description = description;
            Price = price;
            IsActive = true;
        }

        public void Deactivate()
        {
            IsActive = false;
        }

        public void Update(string name, string description, double price, Guid userId)
        {
            Name = name;
            Description = description;
            Price = price;
            IsActive = true;
            AddEditData(userId);
        }
    }
}
