using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product
    {
        string name = "";
        double price = 0;
        int quantity = 0;
        string producer = "";
        double weight = 0;
        Currency cost;

        public string Name 
        {
            get { return name; }
            set { if (value != "") name = value; } 
        }
        public double Price
        {
            get { return price; }
            set { if(value > 0) price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { if (value > 0) quantity = value; }
        }
        public string Producer
        {
            get { return producer; }
            set { if (value != "") producer = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { if (value > 0) weight = value; }
        }
        public Currency Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public Product() 
        {
            cost = new Currency();
        }
        public Product(string name,double price, int quantity, string producer, double weight, Currency cost)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.producer = producer;
            this.weight = weight;
            this.cost = new Currency(cost);
        }
        public Product(string name, double price, Currency cost, int quantity) : this(name, price, quantity, "", 0, cost) { }

        public double GetPriceInUAH()
        {
            return price * cost.ExRate;
        }
        public double GetTotalPriceInUAH()
        {
            return price * quantity * cost.ExRate;
        }
        public double GetTotalWeight()
        {
            return weight * quantity;
        }
    }
}