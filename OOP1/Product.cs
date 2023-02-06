using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        private string _name = "Unknown name";
        private double _price = 0;
        private int _quantity = 0;
        private double _weight = 0;
        private string _producer = "Unknown producer";
        Currency Cost = new Currency();


        public Product()
        {

        }
        public Product(string Name, double Price)
        {
            _name = Name;
            _price = Price; 
        }
        public Product(string name, double price, int quantity, double weight, string producer, Currency cost)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
            _weight = weight;
            _producer = producer;
             Cost = cost; 
        }

        public string Name 
        {
            get => _name;
            set
            {
                if (value != " ")
                {
                    _name = value;
                }
            }
        }
        
        public double Price 
        {
            get => _price;
            set 
            {
                if (value >= 0) 
                {
                    _price = value;
                }
            }
        }
        public int Quantity 
        {
            get => _quantity;
            set 
            {
                if (value > 0) 
                {
                    _quantity = value;
                }
            }
        }
        public double Weight 
        {
            get => _weight;
            set 
            {
                if (value > 0) 
                {
                    _weight = value;
                }
            }
        }
        public string Producer 
        {
            get => _producer;
            set => _producer = value;
        }
        public Currency cost 
        {
            get => Cost;
            set => Cost = new Currency(value);
        }
        public double GetPriceInUAH() 
        {
            return _price*Cost.ExRate;
        }
        public double GetTotalPriceInUAH() 
        {
            double totalPrice = (_price * _quantity)*Cost.ExRate;
            return totalPrice;
        }
        public double GetTotalWeight() 
        {
            return _weight * Cost.ExRate;
        }
    }
}
