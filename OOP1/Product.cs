using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP1
{
    internal class Product
    {
        protected string Name;
        protected double Price;
        protected Currency Cost;
        protected double Quantity;
        protected string Producer;
        protected double Weight;
        public Product()
        {
            Name = "Phone";
            Price = 1000.0;
            Cost = new Currency();
            Quantity = 1;
            Producer = "Apple";
            Weight = 300.0;
        }
        public Product(string name, double price, Currency cost, double quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(string name, double price, Currency cost, double quantity, string producer)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = 00.0;
        }
        public Product(string name, double price, Currency cost, double quantity)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = "Apple";
            Weight = 00.0;
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

        // Getters / Setters down
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetPrice(double price)
        {
            Price = price;
        }
        public double GetPrice()
        {
            return Price;
        }
        public void SetCost(Currency cost)
        {
            Cost = cost;
        }
        public Currency GetCost()
        {
            return Cost;
        }
        public void SetQuantity(double quantity)
        {
            Quantity = quantity;
        }
        public double GetQuantity()
        {
            return Quantity;
        }
        public void SetProducer(string producer)
        {
            Producer = producer;
        }
        public string GetProducer()
        {
            return Producer;
        }
        public void SetWeight(double weight)
        {
            Weight = weight;
        }
        public double GetWeignt()
        {
            return Weight;
        }
        public double GetPriceInUAH()
        {
            return Price * Cost.EXRate;
        }
        public double GetTotalPriceInUAH()
        {
            return Price * Cost.EXRate * Quantity;
        }
        public double GetTotalWeight()
        {
            return Weight*Quantity;
        }
        public override string ToString()
        {
            return $"Name : {Name}\n" +
                   $"Price : {Price}\n" +
                   $"{Cost.ToString()}\n" +
                   $"Quantity : {Quantity}\n" +
                   $"Producer : {Producer}\n" +
                   $"Weight : {Weight}\n" +
                   $"PriceInUAH : {GetPriceInUAH()}\n" +
                   $"TotalPriceInUAH : {GetTotalPriceInUAH()}\n" +
                   $"TotalWeight : {GetTotalWeight()}";
        }
    }
}
