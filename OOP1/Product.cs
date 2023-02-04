using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP1
{
    public class Product
    {

        protected string Name;
        protected double Price;
        protected Currency Currency;
        protected int Quantity;
        protected string Producer;
        protected double Weight;

        public Product()
        {
            this.Name = "no_name";
            this.Price = 1;
            this.Currency = new Currency();
            this.Quantity = 1;
            this.Producer = "own_production";
            this.Weight = 1;
        }

        public Product(string name, double price, Currency currency, int quantity, string producer, double weight):this(name, price, currency, quantity, weight)
        {
            this.Producer = producer;
        }

        public Product(string name, double price, Currency currency, int quantity, double weight)
        {
            this.Name = name;
            this.Price = price;
            this.Currency = currency;
            this.Quantity = quantity;
            this.Producer = "ПП Волков Олександр";
            this.Weight = weight;
        }

        public Product(Product obj)
        {
            this.Name = obj.Name;
            this.Price = obj.Price;
            this.Currency = new Currency(obj.Currency); 
            this.Quantity = obj.Quantity;
            this.Producer = obj.Producer;
            this.Weight = obj.Weight;
        }

        public void SetName(string name)
        {
            if (name.Length >= 2)
            {
                this.Name = name;
            }
        }

        public void SetPrice(double price)
        {
            if (this.Price > 0)
            {
                this.Price = price;
            }
        }

        public void SetCurrency(Currency currency)
        {
            this.Currency = currency;
        }

        public void SetQuantity(int quantity)
        {
            if(this.Quantity >= 0)
            {
                this.Quantity = quantity;
            }
        }

        public void SetProducer(string producer)
        {
            if (producer.Length >= 2)
            {
                this.Producer = producer;
            }
        }

        public void SetWeight(double weight)
        {
            if(weight > 0)
            {
                this.Weight = weight;
            }
        }

        public string GetName()
        {
            return this.Name;
        }

        public double GetPrice()
        {
            return this.Price;
        }
        public Currency GetCurrency()
        {
            return this.Currency;
        }

        public int GetQuantity()
        {
            return this.Quantity;
        }

        public string GetProducer()
        {
            return this.Producer;
        }

        public double GetWeight()
        {
            return this.Weight;
        }

        public double GetPriceInUAH()
        {
            return this.Price*this.Currency.GetExRateCurrency();
        }

        public double GetTotalPriceInUAH()
        {
            return this.Quantity* this.Price * this.Currency.GetExRateCurrency();
        }

        public double GetTotalWeight()
        {
            return this.Quantity * this.Weight;
        }
    }
}
