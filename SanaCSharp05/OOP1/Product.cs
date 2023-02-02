using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        private double price;
        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        private Currency cost;
        public Currency Cost
        {
            set { cost = value; }
            get { return cost; }
        }

        private int quantity;
        public int Quantity
        {
            set { quantity = value; }
            get { return quantity; }
        }

        private string producer;
        public string Producer
        {
            set { producer = value; }
            get { return producer; }
        }

        private double weight;
        public double Weight
        {
            set { weight = value; }
            get { return weight; }
        }

        public Product()
        {
        }

        public Product(string Name, double Price,Currency Cost,int Quant,string Producer, double Weight)
        {
            name = Name;
            price = Price;
            cost = new Currency(Cost);
            quantity = Quant;
            producer = Producer;
            weight = Weight;
        }
        public Product(string Name, double Price, Currency Cost, string Producer, double Weight)
        {
            name = Name;
            price = Price;
            cost = new Currency(Cost);
            quantity = 0;
            producer = Producer;
            weight = Weight;
        }

        public Product(Product product)
        {
            name = product.name;
            price = product.price;
            cost = product.cost;
            quantity = product.quantity;
            producer = product.producer;
            weight = product.weight;
        }

        public double GetPriceInUAH()
        {
            double res = price * cost.ExRate;
            return res;
        }
        public double GetTotalPriceInUAH()
        {
            double res = GetPriceInUAH() * quantity;
            return res;
        }
        public double GetTotalWeight()
        {
            double res = weight * quantity;
            return res;
        }
    }
}
