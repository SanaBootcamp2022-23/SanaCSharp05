using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        protected string Name;
        protected double Price;
        Currency Cost = new Currency(); //сворення об'єкту класу Currency
        protected int Quantity;
        protected string Producer;
        protected double Weight;
        public Product() //конструктор по-замовчуванню
        {
            Name = "TV";
            Price = 500.15;
            Cost = new Currency();
            Quantity = 9;
            Producer = "Samsung";
            Weight = 8.0;
        }
        public Product(string name) //конструктор з параметром(1)
        {
            Name = name;
        }
        public Product(string name, double price, Currency cost) //конструктор з параметром(2)
        {
            Name = name;
            Price = price;
            Cost = cost;
        }
        public Product(string name, double price, Currency cost, int quantity, string producer, double weight) //конструктор з параметром(3)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(Product obj) //конструктор копіювання
        {
            Name = obj.Name;
            Price = obj.Price;
            Cost = obj.Cost;
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;
        }
        // реалізація властивостей Get- та Set-

        public string GetName()
        {
            return Name;
        }
        public double GetPrice()
        {
            return Price;
        }
        public Currency GetCost()
        {
            return Cost;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        public string GetProducer()
        {
            return Producer;
        }
        public double GetWeight()
        {
            return Weight;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetPrice(double price)
        {
            Price = price;
        }
        public void SetCost(Currency cost)
        {
            Cost = cost;
        }
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
        public void SetProducer(string producer)
        {
            Producer = producer;
        }
        public void SetWeight(double weight)
        {
            Weight = weight;
        }
        public double GetPriceInUAH() // метод, повертає ціну товару в гривнях
        {
            return Price * Cost.GetExRate();
        }
        public double GetTotalPriceInUAH() // метод, пов загальну вартість усіх наявних на складі товарів даного виду;
        {
            return Quantity * (Price * Cost.GetExRate());
        }
        public double GetTotalWeight() // мктод, пов повертає загальну вагу усіх товарів на складі даного виду
        {
            return Weight * Quantity;
        }

    }
}
