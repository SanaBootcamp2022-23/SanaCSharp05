using System;

namespace OOP1
{
    internal class Product
    {
        private string _name;
        private double _price;
        private int _quantity;
        private string _producer;
        private double _weight;
        private Currency _cost;

        public string Name
        {
            get => _name;
            set
            {
                if (value != "")
                    _name = value;
                else
                    throw new Exception("Name can't be empty.");
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value > 0)
                    _price = value;
                else
                    throw new Exception("Price must be greater than 0.");
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value > 0)
                    _quantity = value;
                else
                    throw new Exception("Quantity must be greater than 0.");
            }
        }

        public string Producer
        {
            get => _producer;
            set
            {
                if (value != "")
                    _producer = value;
                else
                    throw new Exception("Producer name can't be empty.");
            }
        }

        public double Weight
        {
            get => _weight;
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    throw new Exception("Weight must be greater than 0.");
            }
        }

        public Currency Cost
        {
            get => _cost;
            set => _cost = value;
        }

        public Product()
        {
            Name = "Sugar";
            Price = 10;
            Quantity = 1;
            Cost = new Currency();
            Producer = "SugarProducer";
            Weight = 100.0;
        }

        public Product(string name, double price, Currency cost, double weight, string producer, int quantity)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(Product obj)
        {
            Name = obj._name;
            Price = obj._price;
            Cost = obj._cost;
            Quantity = obj._quantity;
            Producer = obj._producer;
            Weight = obj._weight;
        }

        public double GetPriceInUAH()
        {
            return Cost.ExchangeRate * Price;
        }

        public double GetTotalPriceInUAH()
        {
            return Quantity * Cost.ExchangeRate * Price;
        }

        public double GetTotalWeight()
        {
            return Quantity * Weight;
        }
    }
}
