using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOP1.Currency;
using static OOP1.Display;

namespace OOP1
{
    public class Product
    {
        protected string _name = "Laptop";
        public string Name
        {
            set {
                if(value != null && value != "")
                _name = value; 
            }
            get { return _name; }
        }
        protected double _price = 1600;
        public double Price
        {
            set
            {
                if (value > 0.00001 && value < 10000000) 
                    _price = value;
            }
            get { return _price; }
        }
        protected Currency _cost = new Currency();
        public Currency Cost
        {
            set
            {
                _cost = new Currency();
            }
            get { return _cost; }
        }
        protected int _quantity = 15;
        public int Quantity
        {
            set
            {
                if (value >= 0 && value < 1000) 
                    _quantity = value;
            }
            get { return _quantity; }
        }
        protected string _producer = "Lenovo";
        public string Producer
        {
            set
            {
                if(value!=null && value != "")
                    _producer = value;
            }
            get { return _producer;}
        }
        protected double _weight = 4.2;
        public double Weight
        {
            set
            {
                if(value > 0.001&& value < 10000)
                    _weight = value;
            }
            get { return _weight;}
        }
        public Product()
        {

        }
        public Product(Product product )
        {
            _name= product.Name;
            _price = product.Price;
            _cost = new Currency();
            _quantity = product.Quantity;
            _producer = product.Producer;
            _weight = product.Weight;
        }

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            _name = name;
            _price = price;
            _cost = cost;
            _quantity = quantity;
            _producer = producer;
            _weight = weight;
        }
        public Product(string name, double price, Currency cost)
        {
            _name = name;
            _price = price;
            _cost = cost;
        }
        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }
        public double GetPriceInUAH()
        {
            return  _price * _cost.ExRate;
        }

        public double GetTotalPriceInUAH()
        {
            return _price * _cost.ExRate*_quantity;
        }

        public double GetTotalWeight()
        {
            return _quantity*_weight;
        }

    }
}
