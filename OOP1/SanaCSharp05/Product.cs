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
        protected decimal price;
        protected Currency cost;
        protected int quantity;
        protected string producer;
        protected double weight;
        public Product()
        {

        }

        public Product(string name, decimal price,Currency cost, int quantity, string producer, double weight)
        {
            this.name = name;
            this.price = price;
            this.cost = cost;
            this.quantity = quantity;
            this.producer = producer;
            this.weight = weight;
        }

        public Product(string name, decimal price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public Product(Product obj)
        {
            name = obj.name;
            price = obj.price;
            cost = obj.cost;
            quantity = obj.quantity;
            producer = obj.producer;
            weight = obj.weight;
        }

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
            set { cost = new Currency(value); }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Producer
        {
            get { return producer; }
            set
            {
                producer = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
            }
        }

        public decimal GetPriceInUAH()
        {
            return Price*Cost.ExRate;
        }

        public decimal GetTotalPriceInUAH()
        {
            return Quantity*Cost.ExRate;
        }

        public double GetTotalWeight()
        {
            return Quantity * Weight;
        }
    }
}
