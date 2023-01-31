namespace OOP1;

public class Product
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public Currency Cost { get; set; } = new();
    public int Quantity { get; set; }
    public string Producer { get; set; } = string.Empty;
    public double Weight { get; set; }

    public Product() { }

    public Product(
      string name,
      decimal price,
      Currency cost,
      int quantity,
      string producer,
      double weight)
    {
        Name = name;
        Price = price;
        Cost = cost;
        Quantity = quantity;
        Producer = producer;
        Weight = weight;
    }

    public Product(decimal price, Currency cost, int quantity)
    {
        Price = price;
        Cost = cost;
        Quantity = quantity;
    }

    public Product(Product copiedProduct) : this
    (
      copiedProduct.Name,
      copiedProduct.Price,
      copiedProduct.Cost.Copy(),
      copiedProduct.Quantity,
      copiedProduct.Producer,
      copiedProduct.Weight
    )
    { }

    public Product Copy() => new(this);

    public override string ToString()
    {
        return $"\"{Name}\", price: {Price:N2}, cost: {Cost}" +
            $", quantity: {Quantity}, producer: {Producer}, weight: {Weight}";
    }

    public decimal GetPriceInUAH() => Price * Cost.ExRate;
    public decimal GetTotalPriceInUAH() => GetPriceInUAH() * Quantity;
    public double GetTotalWeight() => Weight * Quantity;
}
