using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public Currency Cost { get; set; }
        public int Quantity { get; set; }
        public string Producer { get; set; }
        public float Weight { get; set; }

        public Product()
        {
            Name = "No name";
            Price = 0;
            Cost = new Currency();
            Quantity = 0;
            Producer = "undefined";
            Weight = 0;
        }
        public Product(string name, float price, Currency cost, int quantity, string producer, float weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(string name, float price, int quantity, string producer, float weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency();
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = new Currency(product.Cost);
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }

    }
}
