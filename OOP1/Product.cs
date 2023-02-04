using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Currency Cost { get; set; }
        public int Quantity { get; set; }
        public string Producer { get; set; }
        public double Weight { get; set; }
        
        public Product()
        {
            Name = "Shoes";
            Price = 800;
            Cost = new Currency("Hryvnia", 36.75);
            Quantity = 2;
            Producer = "Nike";
            Weight = 1;
        }

        public Product(string name, int price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
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
        public int GetPriceInUAH()
        {
            return Price;
        }

        public double GetTotalPriceInUAH()
        {            
            return Quantity * Price;
        }

        public double GetTotalWeight()
        {
            return Quantity * Weight;
        }
    }
    
}
