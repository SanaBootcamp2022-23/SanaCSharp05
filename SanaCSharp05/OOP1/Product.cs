using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        public string Name { get; set; } = "NameProduct";

        private double price;  
        public double Price { get { return price; }
            set { if (value > 0)
                    price = value;
                else throw new ArgumentException("Ціна має бути більшою від нуля");
            } 
        }
        public Currency Cost { get; set; } = new Currency();
        public uint Quantity { get; set; }
        public string Producer { get; set; } = "NameProducer";

        private double weight;
        public double Weight {
            get { return weight; }
            set {
                if (value > 0)
                    weight = value;
                else
                    throw new ArgumentException("Вага має бути більше нуля");
            } 
        }  
        
        public Product()
        {

        }
        public Product(Product product) 
            : this (product.Name,product.Price,new Currency(product.Cost),product.Quantity,product.Producer,product.Weight)
        {        
        }
        public Product(string name, double price, Currency cost, uint quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(string name, double price, Currency cost)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);            
        }

        public double GetPriceInUAH()
        {
            return Price * Cost.ExRate;
        }

        public double GetTotalPriceInUAH()
        {
            return GetPriceInUAH() * Quantity;
        }

        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }
}
