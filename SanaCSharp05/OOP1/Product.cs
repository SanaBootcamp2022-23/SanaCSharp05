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
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       

        public Product(string name, double price, Currency cost, string quantity, string producer, string weight)
        {
            this.name = name;
            this.price = price;
            this.Cost = cost;
            this.quantity = quantity;
            this.producer = producer;
            this.weight = weight;
        }

        protected double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        
        public Currency Cost { get; set; }

        protected string quantity;
        public string Quantity 
        {
            get { return quantity; }
            set
            {
                quantity = value;
            }
        }
        protected string producer;
        public string Producer
        {
            get { return producer; }
            set
            {
                producer = value;
            }
        }
        protected string weight;
        public string Weight
        {
            get { return weight; }
            set
            {
                weight = value;
            }
        }
        public Product(Product obj)
        {
            name = obj.Name;
            weight = obj.Weight;
            price = obj.Price;
            producer = obj.Producer;
            quantity = obj.Quantity;
        }
    }
}
