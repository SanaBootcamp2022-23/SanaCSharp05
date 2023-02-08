using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        protected string Name;
        protected double Price;
        Currency Cost = new Currency();
        protected int Quantity;
        protected string Producer;
        protected double Weight;
        public Product()
        {
            Name = "Laptop";
            Price = 1150;
            Cost = new Currency();
            Quantity = 8;
            Producer = "Lenovo";
            Weight = 2.25;
        }
        public Product(string name)
        {
            Name = name;
        }
        public Product(string name, double price, Currency cost)
        {
            Name = name;
            Price = price;
            Cost = cost;
        }
        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(Product obj)
        {
            Name = obj.Name;
            Price = obj.Price;
            Cost = obj.Cost;
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;
        }

        public string GetName()
        {
            return Name;
        }
        public double GetPrice()
        {
            return Price;
        }
        public Currency GetCost()
        {
            return Cost;
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
        public void SetPrice(double price)
        {
            Price = price;
        }
        public void SetCost(Currency cost)
        {
            Cost = cost;
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
        public double GetPriceInUAH()
        {
            return Price * Cost.GetExRate();
        }
        public double GetTotalPriceInUAH()
        {
            return Quantity * (Price * Cost.GetExRate());
        }
        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }

    }
}
