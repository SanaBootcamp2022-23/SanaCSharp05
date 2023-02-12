using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        protected string name;
        protected double price;
        protected Currency cost;
        protected int quantity;
        protected int producer;
        protected double weight;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Currency Cost
        {
            get { return cost; }
            set { new Currency(value); }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int Producer
        {
            get { return producer; }
            set { producer = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product(string name, double price, Currency cost, int quantity, int producer, double weight) : this(name, price)
        {
            Cost = new Currency(Cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(Product product)
        {
            Name=product.Name;
            Price = product.Price;
            Cost = new Currency(product.Cost);
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }
    }
}
