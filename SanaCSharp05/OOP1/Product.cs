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
        protected Currency Cost;
        protected double Quantity;
        protected string Producer;
        protected double Weight;

        public Product()//конструктор по замовчуванню
        {
            Name = "POCO X3 PRO";
            Price = 10000;
            Cost = new Currency();
            Quantity = 3;
            Producer = "XIAOMI";
            Weight = 300;
        }

        public Product(string name, double price, Currency cost, double quantity, string producer, double weight)//конструктор з параметром
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }  
        public Product(string name, string producer)//конструктор з параметром
        {
            Name = name;
            Producer = producer;
        }

        public Product(Product obj)//конструктор копіювання
        {
            Name = obj.Name;
            Price = obj.Price;
            Cost = new Currency(obj.Cost);
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;
        }

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

        public double GetQuantity()
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

        public void SetQuantity(double quantity)
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
        public double GetPriceInUAH()//повертає ціну одиниці товару в гривнях
        {
            return Price * Cost.GetExRate();
        }

        public double GetTotalPriceInUAH()//повертає загальну вартість усіх наявних на складі товарів даного виду
        {
            return Price * Quantity * Cost.GetExRate();
        }

        public double GetTotalWeight()//повертає загальну вагу усіх товарів на складі даного виду
        {
            return Weight * Quantity;
        }
    }
}
