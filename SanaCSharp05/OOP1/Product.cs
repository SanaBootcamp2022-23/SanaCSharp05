using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP1
{
    public class Product
    {
        protected string _name = "NoName";
        protected decimal _price;
        protected Currency _cost = new Currency();
        protected int _quantity;
        protected string _producer = "NoName";
        protected float _weight;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != "")
                    _name = value;
            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                    _price = value;
            }
        }
        public Currency Cost
        {
            get { return _cost; }
            set { _cost = value; }
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
        public string Producer
        {
            get { return _producer; }
            set
            {
                if (value != "")
                    _producer = value;
            }
        }
        public float Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                    _weight = value;
            }
        }
        public Product() { }

        public Product(string name, decimal price, Currency cost, int quantity,
                string producer, float weight)
        {
            this.Name = name;
            this.Price = price;
            this.Cost = cost;
            this.Quantity = quantity;
            this.Producer = producer;
            this.Weight = weight;
        }

        public Product(string name, decimal price, Currency cost, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Cost = cost;
            this.Quantity = quantity;
        }

        public Product(Product product)
        {
            this.Name = product.Name;
            this.Price = product.Price;
            this.Cost = new Currency(product.Cost);
            this.Quantity = product.Quantity;
            this.Producer = product.Producer;
            this.Weight = product.Weight;
        }
        public decimal GetPriceInUAH()
        {
            return _price * _cost.ex_rate;
        }
        public decimal GetTotalPriceInUAH()
        {
            return _price * _cost.ex_rate * _quantity;
        }
        public float GetTotalWeight()
        {
            return _quantity * _weight;
        }
    }
    }
