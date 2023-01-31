using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        protected string _name;
        protected double _price;
        protected Currency _cost;
        protected uint _quantity;
        protected string _producer;
        protected float _weight;
        
        public string Name
        { 
            get { return _name; }
            set { 
                if (value != "")
                    _name = value;
            } 
        }
        public double Price
        {
            get { return _price; }
            set {
                if (value > 0)
                    _price = value;
            }
        }
        public Currency Cost
        {
            get { return _cost; }
            set { _cost = value;}
        }
        public uint Quantity
        {
            get { return _quantity; }
            set 
            { 
                if(value>=0)
                    _quantity = value;
            }
        }
        public string Producer
        {
            get { return _producer; }
            set {
                if(value != "")
                    _producer = value;
            }
        }
        public float Weight
        {
            get { return _weight; }
            set
            {
                if(value >0)
                    _weight = value;
            }
        }

        public Product()
        {
            _name = "Unknown";
            _price = 1;
            _cost = new Currency();
            _quantity = 0;
            _producer= "Unknown";
            _weight = 0;
        }
        public Product(string name)
        {
            Name = name;
            _price = 1;
            _cost = new Currency();
            _quantity = 0;
            _producer = "Unknown";
            _weight = 0;
        }
        public Product(string name, double price, Currency cost) : this(name)
        {
            Price = price;
            Cost = cost;
        }
        public Product(string name, double price, Currency cost, uint quantity) : this(name, price, cost)
        {
            Quantity = quantity;
        }
        public Product(string name, double price, Currency cost, uint quantity, string producer) : this(name, price, cost, quantity)
        {
            Producer = producer;
        }
        public Product(string name, double price, Currency cost, uint quantity, string producer, float weight) : this(name, price, cost, quantity, producer)
        {
            Weight = weight;
        }
        public Product(Product obj)
        {
            _name = obj.Name;
            _price = obj.Price;
            _cost = obj.Cost;
            _quantity = obj._quantity;
            _producer = obj._producer;
            _weight = obj._weight;
        }

        public double GetPriceInUAH()
        {
            return _price * _cost.ExRate;
        }
        public double GetTotalPriceInUAH()
        {
            return _price * _cost.ExRate * _quantity;
        }
        public float GetTotalWeight()
        {
            return _quantity * _weight;
        }
    }
}
