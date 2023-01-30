namespace OOP1
{
    public class Product
    {
        public string Name { get; private set; } = "";
        public double Price { get; private set; }
        public Currency Cost { get; private set; } = new();
        public int Quantity { get; private set; }
        public string Producer { get; private set; } = "";
        public double Weight { get; private set; }

        public Product() { }

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(Product product)
            : this(product.Name, product.Price, product.Cost, product.Quantity, product.Producer, product.Weight)
        { }

        public double GetPriceInUAH() => Price * Cost.ExRate;
        public double GetTotalPriceInUAH() => Quantity * GetPriceInUAH();
        public double GetTotalWeight() => Quantity * Weight;
    }
}