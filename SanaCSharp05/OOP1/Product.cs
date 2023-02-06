using System;

public class Product
{
    protected string name;
    protected decimal price;
    protected Currency cost;
    protected int quantity;
    protected string producer;
    protected double weight;

    public string Name { get => name; set { name = value; } }
    public string Producer { get => producer; set { producer = value; } }
    public decimal Price { get => price; set { price = value; } }
    public int Quantity { get => quantity; set { quantity = value; } }
    public double Weight { get => weight; set { weight = value; } }
    public Currency Cost { get => cost; set { cost = value; } }

    public Product(string name, decimal price, Currency cost, int quantity, string producer, double weight)
    {
        Name = name;
        Price = price;
        Cost = cost;
        Quantity = quantity;
        Producer = producer;
        Weight = weight;
    }
    public Product()
	{
        Name = "";
        Price = 0;
        Cost = new Currency();
        Quantity = 0;
        Producer = "";
        Weight = 0;
    }
    public Product(Product copyProduct)
    {
        Name = copyProduct.Name;
        Price = copyProduct.Price;
        Cost = copyProduct.Cost;
        Quantity = copyProduct.Quantity;
        Producer = copyProduct.Producer;
        Weight = copyProduct.Weight;
    }
    public decimal GetPriceInUAH()
    {
        return Price * Cost.exRate;

    }
    public decimal GetTotalPriceInUAH()
    {
        return Price * Cost.exRate * Quantity;
    }

    public double GetTotalWeight()
    {
        return Weight * Quantity;

    }
    public class Currency
    {
        protected string name;
        protected decimal ExRate;
        public Currency(string name, decimal ExRate)
        {
            Name = name;
            exRate = ExRate;
        }
        public Currency(string name)
        {
            Name = name;
        }
        public Currency()
            {

            }
        public string Name { get => name; set { name = value; } }
    public decimal exRate { get => ExRate; set { ExRate = value; } }

        public Currency(Currency copyCurrency)
        {
            Name = copyCurrency.Name;
            exRate = copyCurrency.ExRate;

        }
    }
}
