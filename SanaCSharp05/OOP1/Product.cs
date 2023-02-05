using OOP1;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace OOP1
{
    class Product
    {
        protected string Name;
        protected double Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight;

        public Product(Product obj)
        {
            Name = obj.Name;
            Price = obj.Price;
            Cost = obj.Cost;
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;
        }
        public Product() { }

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            this.Name = name;
            this.Price = price;
            this.Cost = cost;
            this.Quantity = quantity;
            this.Producer = producer;
            this.Weight = weight;
        }
        public Product(string Name, string Producer)
        {
            this.Name = Name;
            this.Producer = Producer;
        }

        public string NAme
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string PRoducer
        {
            get
            {
                return Producer;
            }
            set
            {
                Producer = value;
            }
        }
        public double PRice
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }
        public double GetPriceInUAH()
        {
            return Price * Cost.EXRate;
        }
        public double GetTotalPriceInUAH()
        {
            return Quantity * (Price * Cost.EXRate);
        }
        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }
}