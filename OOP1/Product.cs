using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        protected string name;
        protected decimal price;
        protected Currency cost;
        protected int quantity;
        protected string producer;
        protected double weight;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public Currency Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Producer
        {
            get { return producer; }
            set { producer = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Product()
        {
            Name = "Iphone11";
            Price = 330;
            Cost = new Currency();
            Quantity = 5;
            Producer = "Apple";
            Weight = 200;
        }

        public Product(string name, decimal price, object cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency();
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }   

        public Product(Product otherProduct)
        {
            Name = otherProduct.Name;
            Price = otherProduct.Price;
            Cost = otherProduct.Cost;
            Quantity = otherProduct.quantity;
            Producer = otherProduct.producer;
            Weight = otherProduct.weight;
        }

        public decimal GetPriceInUAH()
        {
            var uah = Price * Cost.ExRate;
            return uah;
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
}
