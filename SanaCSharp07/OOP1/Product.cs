using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP1;
namespace OOP1
{
    internal class Product
    {
        protected string name;
        protected double price;
        protected Currency cost;
        protected int quantity;
        protected string producer;
        protected double weight;
        public string Name
        { get { return name; } 
            set 
            { if (value != "")
                    name = value;
                else throw new Exception("Error");
                        } 
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
                else throw new Exception("Error");
            }
        }
             public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                    value = quantity;
                else throw new Exception("Error");
            }
        }
            public string Producer
        {
            get { return producer; }
            set
            {
                if (value != "")
                    producer = value;
                else throw new Exception("Error");
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
                else throw new Exception("Error");
            }
        }

        public Currency Cost
        { 
                        get { return cost; }
    set
            {
                if (value > 0)
                    cost = value;
                else throw new Exception("Error");
}
        }

        public Product()
        {
            Name = "Banana";
            Price = 10;
            Quantity = 1;
            Cost = new Currency();
            Producer = "BananaProducer";
            Weight = 100.0;
        }
        public Product(string name, double price, Currency cost, double weight, string producer, int quantity)
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
            Name = obj.name;
            Price = obj.price;
            Cost = obj.cost;
            Quantity = obj.quantity;
            Producer = obj.producer;
            Weight = obj.weight;
        }
        public double GetPriceInUAH()
        {
            return Cost.ExRate * Price;
        }
        public double GetTotalPriceInUAH()
        {
            return Quantity*Cost.ExRate * Price;
        }
        public double GetTotalWeight()
        {
            return Quantity * Cost.ExRate;
        }
    }
        }
       

