using System;
namespace OOP1
{
    public class Product
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { if (!String.IsNullOrEmpty(name)) name = value; }
        }
        protected double price;
        public double Price
        {
            get { return price; }
            set { if (value > 0) price = value; }
        }
        protected Currency cost;
        public Currency Cost
        {
            get { return cost; }
            set { if (!(value is null)) cost = new Currency(value); }
        }
        protected int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { if (value >= 0) quantity = value; }
        }
        protected string producer;
        public string Producer
        {
            get { return producer; }
            set { if (!String.IsNullOrEmpty(producer)) producer = value; }
        }
        protected double weight;
        public double Weight
        {
            get { return weight; }
            set { if (value > 0) weight = value; }
        }

        public Product()
        {
            Name = "IPhone";
            Price = 1000;
            Cost = new Currency("Dolar", 37.44);
            Quantity = 15;
            Producer = "Apple";
            Weight = 150;
        }
        public Product(string name, double price, Currency cost)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
        }
        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
            : this(name, price, cost)
        {
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = new Currency(product.Cost);
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }

        public double GetPriceInUAH()
        {
            return Price * Cost.ExRate;
        }
        public double GetTotalPriceInUAH()
        {
            return GetPriceInUAH() * Quantity;
        }
        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }
}
