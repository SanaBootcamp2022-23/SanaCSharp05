using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product
    {
        private string _name = "Unknown";
        private double _price = 0;
        private int _quantity = 0;
        private string _producer = "Unknown";
        private double _weight = 0;
        private Currency _cost = new Currency();
        public Product(string name, double price, int quantity, string producer, int weight, Currency cost)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
            _producer = producer;
            _weight = weight;
            _cost = cost;
        }
        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _name = value;
            }
        }
            
       
        public double Price
        {
            get { return _price; }
            set {
                if (value >= 0)
                    _price = value;
            }
        }
        public Currency Cost
        {
            get { return _cost; }
            set {
                _cost = value;
            }
        }

        public string Producer
        {
            get { return _producer; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _producer = value;
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value >= 0)
                    _quantity = value;
            }
        }
        
        public Product Copy()
        {
            return new(this);
        }
        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value >= 0)
                    _weight = value;
            }
        }
        public Product (Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = product.Cost;
            Producer = product.Producer;
            Quantity = product.Quantity;
            Weight = product.Weight;
        }
        public double GetPriceInUAH()
        {
            return Price * Cost.ExRate;
        }
        public double GetTotalPriceInUAH()
        {
            return Quantity * GetPriceInUAH();
        }
        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }
}
