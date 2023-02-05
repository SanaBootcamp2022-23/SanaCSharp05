using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        protected string name;
        protected double price;
        protected Currency cost;
        protected int quantity;
        protected string producer;
        protected double weight;
        public string Name
        {
            set {
                if (value != "") 
                    name = value;
            }
            get {
                return name;
            }
        }
        public double Price
        {
            set {
                if (value > 0) 
                    price = value;
            }
            get { 
                return price; 
            }
        }
        public Currency Cost
        {
            set {
                cost = new Currency(value);
            }
            get {
                return cost;
            }
        }
        public int Quantity
        {
            set {
                quantity = value;
            }
            get {
                return quantity;
            }
        }
        public string Producer
        {
            set {
                if (value != "")
                    producer = value;
            }
            get {
                return producer;
            }
        }
        public double Weight
        {
            set
            {
                if (value > 0) {
                    weight = value;
                }
            }
            get
            {
                return weight;
            }
        }
        public Product() {
            Name = "Відеокарта Radeon R9 270";
            Price = 94.99;
            Cost = new Currency("USD", 36.93);
            Quantity = 25;
            Producer = "Sapphire";
            Weight = 1.50;
        }
        public Product(string name, double price, Currency cost, int quantity, string producer, double weight) { 
            Name = name;
            Price = price;
            Cost = new Currency();
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(Product obj) {
            Name = obj.Name;
            Price = obj.Price;
            Cost = new Currency(obj.Cost);
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;
        }
        public string GetPriceInUAH(Product obj) {
            return $"Ціна товару \"{obj.Name}\" в гривнях - {Math.Round(obj.Price * obj.Cost.ExRate), 2} грн.";
        }
        public string GetTotalPriceInUAH(Product obj) {
            return $"Ціна всіх товарів виду \"{obj.Name}\" в гривнях - {Math.Round(obj.Price * obj.Quantity * obj.Cost.ExRate), 2} грн.";
        }
        public string GetTotalWeight(Product obj) {
            return $"Сумарна вага всіх товарів виду \"{obj.Name}\" - {Math.Round(obj.Weight * obj.Quantity, 2)} кг.";
        }
    }
}
