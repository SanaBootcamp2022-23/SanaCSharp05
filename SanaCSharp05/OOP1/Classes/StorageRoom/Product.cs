using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Classes.StorageRoom
{
    public class Product
    {
        protected string name = "Laptop";
        protected string producer = "Lenovo";
        protected decimal price = 43000.00M;
        protected int quantity = 3;
        protected Currency cost = new Currency();
        protected decimal weight = 3.25M;

        public string Name { get => name;
            set {
                if (value.Length >= 4)
                    name = value;
            }
        }
        public string Producer
        {
            get => producer;
            set
            {
                if (value.Length >= 3)
                    producer = value;

            }
        }
        public decimal Price { get => price;
            set {
                if (value > 0)
                    price = value;
            } 
        }
        public int Quantity
        {
            get => quantity;
            set
            {
                if (value > 0)
                    quantity = value;
            }
        }
        public Currency Cost { get => cost; set => cost = value; }
        public decimal Weight { get => weight;
            set {
                if (value > 0)
                    weight = value;
            } 
        }

        public Product() { }
        public Product(string Name, string Producer, decimal Price)
        {
            this.Name = Name;
            this.Producer = Producer;
            this.Price = Price;
        }
        public Product(string Name, string Producer, decimal Price, int Quantity):this(Name, Producer, Price) {
            this.Quantity = Quantity;
        }
        public Product(string Name, string Producer, decimal Price, int Quantity, Currency Cost,   decimal Weight) 
            : this(Name, Producer, Price, Quantity) {
            this.Cost = new Currency(Cost);
            this.Weight = Weight;
        }
        public Product(Product product) 
            :this(product.Name, product.Producer, product.Price, product.Quantity, product.Cost, product.Weight) { }

        public decimal GetPriceInUAH()
        {
            decimal priceInUAH = Price;
            if(Cost.Name != "UAH")
                priceInUAH = Cost.ExRate * Price;
            return priceInUAH;
        }

        public decimal GetTotalPriceInUAH() =>GetPriceInUAH() * Quantity;

        public decimal GetTotalWeight() => Quantity * Weight;

        public override string ToString()
        {
            return $"Назва товару - {Name} \tВиробник - {Producer} \tЦіна - {Price} " +
                $"\tКількість товарів на складі - {Quantity} \n{Cost.ToString()} \t Вага - {Weight}";
        }
    }
}
