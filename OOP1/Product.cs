using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product
    { // поля оголошено(ззахищені) 3.5
        protected string name;
        protected double price;
        protected Currency cost;
        protected int quantity;
        protected string producer;
        protected double weight;

        //сетери та гетери 3.7
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public Currency Cost { get => cost; set => cost = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Producer { get => producer; set => producer = value; }
        public double Weight { get => weight; set => weight = value; }

        public Product()
        {
            //конструктор по замовчуванню 3.6
        }

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            //конструктор з параметрами 3.6
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(string name, double price, Currency cost)
        {
            //конструктор з параметрами 3.6
            Name = name;
            Price = price;
            Cost = cost;
        }

        public Product(Product copyProduct)
        {
            //конструктор копіювання 3.6
            Name = copyProduct.Name;
            Price = copyProduct.Price;
            Cost = copyProduct.Cost;
            Quantity = copyProduct.Quantity;
            Producer = copyProduct.Producer;
            Weight = copyProduct.Weight;
        }

        public double GetPriceInUAH()           //метод, який повертає ціну одиниці товару в гривнях 3.8
        {
            Console.Write($"Ціна  {this.Name} за одиницю товару у гривнях: ");
            return Price * Cost.ExRate;
        }

        public double GetTotalPriceInUAH()     //метод, що повертає загальну вартість усіх наявних на складі товарів даного виду 3.8
        {
            Console.Write($"Ціна усіх {this.Name} наявних на  складі: ");
        
            return Price * Cost.ExRate * Quantity;
        }

        public double GetTotalWeight()
        {
            Console.Write($"Вага усіх {this.Name} на складі: ");
            //метод, який повертає загальну вагу усіх товарів на складі даного виду 3.8
            return Weight * Quantity;
            
        }
    }
}
