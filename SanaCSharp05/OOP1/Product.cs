using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > Constants.MAX_STRING_SIZE)
                    throw new ArgumentException("String too long!");
                name = value;
            }
        }
        protected string name;

        public double Price { get; set; }

        public Currency Cost{ get; set; }

        public int Quantity { get; set; }

        public string Producer
        {
            get { return producer; }
            set
            {
                if (value.Length > Constants.MAX_STRING_SIZE)
                    throw new ArgumentException("String too long!");
                producer = value;
            }
        }
        protected string producer;

        public double Weight { get; set; }

        public Product()
        {
            Name = "New Product";
            Price = 10;
            Cost = Currency.Default;
            Quantity = 0;
            Producer = "Unknown Producer";
            Weight = 1;
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

        public Product(string name, double price, Currency cost, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = 0;
            Producer = "Unknown Producer";
            Weight = weight;
        }

        public Product(Product obj)
        {
            Name = obj.Name;
            Price = obj.Price;
            Cost = obj.Cost;
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;
        }

        public double GetPriceInUAH() => Cost.ExRate * Price;

        public double GetTotalPriceInUAH() => Quantity * Cost.ExRate * Price;

        public double GetTotalWeight() => Quantity * Weight;


    }
}
