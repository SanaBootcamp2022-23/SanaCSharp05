using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP1
{
    public class Product
    {
        protected string _name = "No name";
        protected double _price = 100;
        protected Currency _cost = new Currency();
        protected int _quantity = 100;
        protected string _producer = "No name";
        protected double _weight = 100;
        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public Product(string name, double price, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(Product product) : this(product.Name, product.Price, product.Cost, product.Quantity, product.Producer, product.Weight)
        {
        }

        public string Name
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
            get
            {
                return _name;
            }
        }
        public double Price
        {
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
            get
            {
                return _price;
            }
        }
        public Currency Cost
        {
            set; get;
        }
        public int Quantity
        {
            set
            {
                if (value > 0)
                {
                    _quantity = value;
                }
            }
            get
            {
                return _quantity;
            }
        }
        public string Producer
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _producer = value;
                }
            }
            get
            {
                return _producer;
            }
        }
        public double Weight
        {
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
            get
            {
                return _weight;
            }
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
