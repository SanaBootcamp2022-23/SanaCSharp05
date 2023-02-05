using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product
    {
        protected string Name;
        public string _name
        {
            set
            {
                if (value != "")
                {
                    Name = value;
                }
            }
            get { return Name; }
        }
        protected int Price;
        public int price
        {
            set
            {
                if(value > 0)
                {
                    Price = value;
                }
            }
            get { return Price; }
        }
        protected Currency Cost;
        public Currency cost
        {
            set
            {
                Cost = new Currency();
            }
            get { return Cost; }
        }
        protected int Quantity;
        public int quantity
        {
            set
            {
                if (value > 0)
                {
                    Quantity = value;
                }
            }
            get { return Quantity; }
        }

        protected string Producer;
        public string producer
        {
            set
            {
                if (value != "")
                {
                    Producer = value;
                }
            }
            get { return Producer; }
        }
        protected int Weight;
        public int weight
        {
            set
            {
                if(value > 0)
                {
                    Weight = value;
                }
            }
            get { return Weight; }
        }
        
        public Product()
        {

        }

        public Product(string name, int price, Currency cost, int quantity, string producer, int weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(string name, int price, int quantity, string producer)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Producer = producer;         
        }

        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = product.Cost;
            Quantity = product.Quantity;   
            Producer = product.Producer;
            Weight = product.Weight;
        }

        public int GetPriceInUAH() => Cost.exRate * Price;
        public int GetTotalPriceInUAH() => GetPriceInUAH() * Quantity;
        public double GetTotalWeight() => Weight * Quantity;
    }
}
