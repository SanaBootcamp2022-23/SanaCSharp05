using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOOP1
{
    public class Product
    {
        protected string Name;
        protected decimal Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight;

        public Product(string name, decimal price, Currency cost, 
            int quantity, string producer, double weight)
        {
            this.Name = name;
            this.Price = price;
            this.Cost = cost;
            this.Quantity = quantity;
            this.Producer = producer;
            this.Weight = weight;
        }

        public Product(string name, decimal price)
        { 
            this.Name = name;
            this.Price = price; 
        }

        public Product(Product previousProduct)
        { 
            this.Name = previousProduct.Name;
            this.Price = previousProduct.Price;
            this.Cost = previousProduct.Cost;
            this.Quantity = previousProduct.Quantity;
            this.Producer = previousProduct.Producer;
            this.Weight = previousProduct.Weight;
        }

        public string name
        {
            set { if(value != null) Name = value; }
            get { return Name; }
        }
        
        public decimal price
        {
            set { if (value > 0) Price = value; }
            get { return Price; }
        }

        public Currency cost
        {
            set { if (value != null) Cost = value; }
            get { return Cost; }
        }

        public int quantity
        {
            set { if(value >= 0) Quantity = value; }
            get { return Quantity; }
        }

        public string producer
        {
            set { if (value != null) Producer = value; }
            get { return Producer; }    
        }

        public double weight
        {
            set { if (value > 0) Weight = value; }
            get{ return Weight;}
        }

        public decimal GetPriceInUAH()
        { 
            return Price * Cost.exRate; 
        }

        public decimal GetTotalPriceInUAH()
        { 
            return Quantity * GetPriceInUAH();
        }

        public double GetTotalWeight()
        {
            return Quantity * Weight;
        }
    }
}
