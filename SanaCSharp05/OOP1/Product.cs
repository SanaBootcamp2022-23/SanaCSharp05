using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        protected string Name = "Unknown";
        protected decimal Price = 0;
        protected Currency Cost;
        protected int Quantity = 0;
        protected string Producer = "Unknown";
        protected double Weight = 0;
        public Product() { }
        public Product(string name, decimal price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(string name, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(Product obj)
        {
            Name = obj.Name;
            Price = obj.Price;
            Cost = new Currency(obj.Cost);
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Price: {Price}");
            Cost.PrintFullCurrency();
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Produce: {Producer}");
            Console.WriteLine($"Weight: {Weight}\n");
        }
        public string GetName()
        {
            return Name;
        }
        public decimal GetPrice()
        {
            return Price;
        }
        public void GetCost()
        {
            Cost.PrintFullCurrency();
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        public string GetProducer()
        {
            return Producer;
        }
        public double GetWeight()
        {
            return Weight;
        }
        public void SetName(string name) 
        {
            Name = name;
        }
        public void SetPrice(decimal price)
        {
            Price = price;
        }
        public void SetCost(string nameCost, decimal exCost)
        {
            Cost = new Currency(nameCost, exCost);
        }
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
        public void SetProducer(string producer)
        {
            Producer = producer;
        }
        public void SetWeight(double weight)
        {
            Weight = weight;
        }
        public decimal GetPriceInUAH()
        {
            decimal exRate = Cost.GetExRate();
            return Price * exRate;
        }
        public decimal GetTotalPriceInUAH()
        {
            decimal exRate = Cost.GetExRate();
            return Price * exRate * Quantity;
        }
        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }
}
