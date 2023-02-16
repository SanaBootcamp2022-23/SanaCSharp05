using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product
    {
        protected string Name { get; set; }
        protected double Price { get; set; }
        protected Currency Cost { get; set; }
        protected int Quantity { get; set; }
        protected string Producer { get; set; }
        protected int Weight { get; set; }
        
        public Product() 
        { 
            Name = string.Empty;
            Price = 0;
            Cost = new Currency();
            Quantity = 0;
            Producer = string.Empty;
            Weight = 0;
        }

        public Product(string name, double price, Currency cost, int quantity, string producer, int weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(string name, double price, Currency cost, int quantity, string producer)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = 0;
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

        public double GetPriceInUAH()
        {
            if (Cost.Name == "UAH")
            {
                return Price;
            }
            return Cost.ExRate * Price;
        }

        public double GetTotalPriceInUAH()
        {
            return GetPriceInUAH() * Quantity;
        }

        public int GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }
}
