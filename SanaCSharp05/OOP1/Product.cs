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
        protected string Name;
        protected int Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight;

        public Product()
        {
            Name = "Unknown";
            Price = 10; 
            Cost = new Currency();
            Quantity = 0;
            Producer = "Polytechnic";
            Weight = 1.00;
        } 

        public Product (string name, int price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(string name, int price, Currency cost, string producer)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = 0;
            Producer = producer;
            Weight = 1.00;
        }
        public Product (Product prd)
        {
            Name = prd.Name;
            Price = prd.Price;
            Cost = prd.Cost;
            Quantity = prd.Quantity;
            Producer = prd.Producer;
            Weight = prd.Weight;
        }

        public string GetName ()
        {
            return Name;
        }
        public void SetName(string name) 
        {
            if (!String.IsNullOrEmpty(name))
                Name = name;
            else 
                Name = "Unknown";
        }
        public int GetPrice ()
        {
            return Price; 
        }
        public void SetPrice (int price)
        {
            if (Price >= 0)
                Price = price;
            else 
                Price = 0;
        }
        public Currency GetCost ()
        {
            return Cost; 
        }
        public void SetCost(Currency сost)
        {
            Cost = new(сost);
        }
        public int GetQuantity ()
        {
            return Quantity;
        }
        public void SetQuantity (int quantity)
        {
            if (quantity >= 0)
                Quantity = quantity;
            else 
                Quantity = 0;
        }
        public string GetProducer ()
        {
            return Producer;
        }
        public void SetProducer(string producer)
        {
            if (!String.IsNullOrEmpty(producer))
                Producer = producer;
            else 
                Producer = "Unknown";
        }
        public double GetWeight()
        {
            return Weight;
        }
        public void SetWeight (double weight)
        {
            if (weight >= 0)
                Weight = weight;
            else 
                Weight = 0;
        }
        public string GetPriceInUAH(Product prd) 
        {
            return $"Ціна товару з назвою {Name} у валюті UAH = {Math.Round(prd.GetPrice() * prd.Cost.GetExRate(), 2)}!";
        }
        public string GetTotalPriceInUAH (Product prd)
        {
            return $"Ціна усіх товарів {prd.Name} у валюті UAH = {Math.Round(prd.GetQuantity() * prd.GetPrice() * prd.Cost.GetExRate(), 2)}!";
        }
        public string GetTotalWeight (Product prd)
        {
            return $"Сумарна вага всіх товарів {prd.Name} = {Math.Round(prd.GetWeight() * prd.GetQuantity(), 2)} kg!";
        }
    } 
}
