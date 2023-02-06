using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        protected string Name = "Milk";
        protected double Price = 35;
        protected Currency Cost = new Currency("UAH", 1);  
        protected int Quantity = 2;
        protected string Producer = "Scotti";
        protected double Weight = 930;

        //Конструктор по замовчуванню
        public Product() { }
       
        //Set та Get 
        public string name
        {
            get { return Name; }
            set { if (value != null) { Name = value; } }
        }
        public double price
        {
            get { return Price; }
            set { if (value > 0) { Price = value; } }
        }
        public Currency cost
        {
            get { return Cost; }
            set { if (value != null) { Cost = value; } }
        }
        public int quantity
        {
            get { return Quantity; }
            set { if (value >= 0) { Quantity = value; } }
        }
        public string producer
        {
            get { return Producer; }
            set { if (value != null) { Producer = value; } }
        }
        public double weight
        {
            get { return Weight; }
            set { if (value >= 0) { Weight = value; } }
        }
        
        //Конструктори з параметрами
        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(string name, double price, Currency cost, string producer)
        {
            Name= name;
            Price = price;
            Cost = cost;
            Producer = producer;
        } 

        //Конструктор копіювання
        public Product(Product productCopy) : this(productCopy.Name, productCopy.Price, productCopy.Cost, productCopy.Quantity, productCopy.Producer, productCopy.Weight) { }

        //Методи
        public double GetPriceInUAH()
        {
            return Price * Cost.exRate;
        }
        public double GetTotalPriceInUAH()
        {
            return Price * Cost.exRate * Quantity;
        }
        public double GetTotalWeight()
        {
            return (Weight * Quantity)/1000;
        }
        public void PrintInfoProd()
        {
            Console.WriteLine($"Назва продукту: {name}");
            Console.WriteLine($"Ціна: {price}");
            Console.WriteLine($"Валюта: {cost.name}");
            Console.WriteLine($"Курс: {cost.exRate}");
            Console.WriteLine($"Кількість: {quantity} шт.");
            Console.WriteLine($"Виготовник: {producer}");
            Console.WriteLine($"Вага: {weight}гр.");
            Console.WriteLine($"Ціна одиниці товару в гривнях: {GetPriceInUAH()} UAH");
            Console.WriteLine($"Загальна вартість усіх наявних на складі товарів даного виду: {GetTotalPriceInUAH()} UAH");
            Console.WriteLine($"Загальна вага усіх товарів на складі даного виду: {GetTotalWeight()}кг.");
            Console.WriteLine();
        }
    }
}
