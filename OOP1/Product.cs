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
        protected double price;
        protected Currency cost;
        protected uint quantity;
        protected string producer;
        protected double weight;
        public Product()
        {
            name = "Chocolate";
            price = 120;
            cost = new Currency();
            quantity = 1;
            producer = "Roshen";
            weight = 0.2;
        }
        public Product(string Name, double Price, Currency Cost, uint Quantity, string Producer, double Weight)
        {
            name = Name;
            price = Price;
            cost = Cost;
            quantity = Quantity;
            producer = Producer;
            weight = Weight;
        }
        public Product(string Name, Currency Cost, uint Quantity, string Producer)
        {
            name = Name;
            price = 120;
            cost = Cost;
            quantity = Quantity;
            producer = Producer;
            weight = 0.2;
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
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public double Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }
        public Currency Cost
        {
            set
            {
                cost = value;
            }
            get
            {
                return cost;
            }
        }
        public uint Quantity
        {
            set
            {
                quantity = value;
            }
            get
            {
                return quantity;
            }
        }
        public string Producer
        {
            set
            {
                producer = value;
            }
            get
            {
                return producer;
            }
        }
        public double Weight
        {
            set
            {
                weight = value;
            }
            get
            {
                return weight;
            }
        }
        public double GetPriceInUAH()
        {
            if (Cost.Name.Equals("UAH"))
                return price;
            else
                return price * Cost.ExRate;
        }
        public double GetTotalPriceInUAH()
        {
            return quantity * GetPriceInUAH();
        }
        public double GetTotalWeight()
        {
            return weight * quantity;
        }
    }
}
