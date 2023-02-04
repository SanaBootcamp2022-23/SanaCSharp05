using OOP1;

public class Product
{
    protected string name;
    protected decimal price;
    protected Currency cost;
    protected int quantity;
    protected string producer;
    protected double weight;

    public Product()
    {
        Name = "";
        Price = 0;
        Cost = new Currency();
        Quantity = 0;
        Producer = "";
        Weight = 0;
    }

    public Product(string name, decimal price, Currency cost, int quantity, string producer, double weight)
    {
        Name = name;
        Price = price;
        Cost = cost;
        Quantity = quantity;
        Producer = producer;
        Weight = weight;
    }

    public Product(Product original)
    {
        Name = original.Name;
        Price = original.Price;
        Cost = original.Cost;
        Quantity = original.Quantity;
        Producer = original.Producer;
        Weight = original.Weight;
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Product name cannot be empty.");
            }
            name = value;
        }
    }

    public decimal Price
    {
        get => price;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price must be a positive number.");
            }
            price = value;
        }
    }

    public Currency Cost
    {
        get => cost;
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cost currency cannot be null.");
            }
            cost = value;
        }
    }

    public int Quantity
    {
        get => quantity;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Quantity must be a positive number.");
            }
            quantity = value;
        }
    }

    public string Producer
    {
        get => producer;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Producer name cannot be empty.");
            }
            producer = value;
        }
    }

    public double Weight
    {
        get => weight;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Weight must be a positive number.");
            }
            weight = value;
        }
    }

    public decimal GetPriceInUAH()
    {
        return Price * (decimal)Cost.GetExRate();
    }

    public decimal GetTotalPriceInUAH()
    {
        return GetPriceInUAH() * Quantity;
    }

    public double GetTotalWeight()
    {
        return Weight * Quantity;
    }
}
