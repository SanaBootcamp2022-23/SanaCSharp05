using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        protected string Name;
        protected int Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected int Weight;
        public string name
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Name = value;
                }
            }
            get { return Name; }
        }
        public int price
        {
            set 
            {
                if (value > 0)
                {
                    Price = value;
                }
            }
            get { return Price; }
        }
        public Currency cost
        {
            set { Cost = value; }
            get { return Cost; }
        }
        public int quantity
        {
            set
            {
                if (value >= 0)
                {
                    Quantity = value;
                }
            }
            get { return Quantity; }
        }
        public string producer
        {
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Producer = value;
                }
            }
            get { return Producer; }
        }
        public int weight
        {
            set
            {
                if (value > 0)
                {
                    Weight = value;
                }
            }
            get { return Weight; }
        }
        public Product()
        {
            Name = "No Data";
            Price = 0;
            Cost = new Currency();
            Quantity = 0;
            Producer = "No Data";
            Weight = 0;
        }
        public Product(string name, int price, Currency cost, int quantity, string producer, int weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(string name, int price, Currency cost, string producer, int weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = 1;
            Producer = producer;
            Weight = weight;
        }
        public Product(Product product) : this(product.Name, product.Price, new Currency(product.Cost), 
            product.Quantity, product.Producer, product.Weight)
        { 

        }
        public double GetPriceInUAH()
        {
            return Price * Cost.exRate;
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
