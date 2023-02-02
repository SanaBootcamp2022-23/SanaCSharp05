using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        private string _name = "Unknown";
        private double _price = 0;
        private Currency _cost = new();
        private int _quantity = 0;
        private string _producer = "Unknown";
        private double _weight = 0;

        //властивості
        public string Name
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _name = value;
            }
            get { return _name; }
        }
        public double Price
        {
            set
            {
                if (value >= 0)
                    _price = value;
            }
            get { return _price; }
        }
        public Currency Cost
        {
            set { _cost = value; }
            get { return _cost; }
        }
        public int Quantity
        {
            set
            {
                if (value >= 0)
                    _quantity = value;
            }
            get { return _quantity; }
        }
        public string Producer
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _producer = value;
            }
            get { return _producer; }
        }
        public double Weight
        {
            set
            {
                if (value >= 0)
                    _weight = value;
            }
            get { return _weight; }
        }

        //по замовчуванню
        public Product() { }
        //конструктори з параметрами
        public Product(string name, double price, Currency cost)
        {
            Name = name;
            Price = price;
            Cost = cost;
        }
        public Product(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
        public Product(double price, Currency cost)
        {
            Price = price;
            Cost = cost;
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
        //конструктор копіювання
        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = product.Cost.Copy();
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }
        public Product Copy()
        {
            return new(this);
        }

        //отримуємо гривні та загальну ціну
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
            return Quantity * Weight;
        }
    }
}
