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
        public string Name
        {
            set { 
                if (value != "")
                    name = value; 
                }
            get { return name; }
        }

        protected double price;
        public double Price
        {
            set { 
                if (value > 0)
                    price = value; 
                }
            get { return price; }
        }

        protected Currency cost = new Currency();
        public Currency Cost
        {
            set; get;
        }

        protected int quantity;
        public int Quantity
        {
            set{
                if (value > -1) 
                    quantity = value;
                }
            get { return quantity; }
        }

        protected string producer;
        public string Producer
        {
            set
            {
                if (value != "")
                    producer = value;
            }
            get { return producer; }
        }

        protected double weight;
        public double Weight
        {
            set
            {
                if (value > 0)
                    weight = value;
            }
            get { return weight; }
        }

        public Product()
        {
            Name = "Snickers";
            Price = 19.0;
            Cost = new Currency();
            Quantity = 10;
            Producer = "Mars";
            Weight = 0.05;
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

        public Product (string name, double price, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency();
            Quantity = 10;
            Producer = producer;
            Weight = weight;
        }

        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = product.Cost;
            Quantity = product.quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }

        public double GetPriceInUAH()
        {
            return Price * Cost.exRate;
        }
        public double GetTotalPriceInUAH()
        {
            return Price * Cost.exRate * Quantity;
        }
        public double GetTotalWeight()
        {
            return (Weight * Quantity) / 1000;
        }
    }
}
