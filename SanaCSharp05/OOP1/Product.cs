namespace OOP1
{
    public class Product
    {
		private string name;
		public string Name
		{
			get { return name; }
			set { if (!string.IsNullOrEmpty(value)) name = value; }
		}
		private decimal price;
		public decimal Price
		{
			get { return price; }
			set { if (value > 0) price = value; }
		}
		private int quantity;
		public int Quantity
        {
			get { return quantity; }
			set { if (value >= 0) quantity = value; }
		}
		private string producer;
		public string Producer
        {
			get { return producer; }
			set { if (!string.IsNullOrEmpty(value)) producer = value; }
		}
		private double weight;
		public double Weight
        {
			get { return weight; }
			set { if (value > 0) weight = value; }
		}
		private Currency cost;
		public Currency Cost
		{
			get { return cost; }
			set { if (value != null) cost = new Currency(value); }
		}
		public Product() { }
		public Product(Product product)
		{
			Name = product.Name;
			Price = product.Price;
			Quantity = product.Quantity;
			Producer = product.Producer;
			Weight = product.Weight;
			Cost = new Currency(product.Cost);
		}
		public Product(string name, decimal price, Currency cost, int quantity)
		{
			Name = name;
			Price = price;
			Cost = new Currency(cost);
			Quantity = quantity;
		}
		public Product(string name, decimal price, Currency cost, string producer, double weight, int quantity) : this(name, price, cost, quantity)
		{
			Producer = producer;
			Weight = weight;
		}
		public decimal GetPriceInUAH() => Price * Cost.ExRate;
		public decimal GetTotalPriceInUAH() => Quantity * GetPriceInUAH();
		public double GetTotalWeight() => Quantity * Weight;
    }
}
