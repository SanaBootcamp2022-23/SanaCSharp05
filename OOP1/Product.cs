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
        protected int Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected int Weight;
        
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
