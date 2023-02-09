using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        protected string Name;
        protected uint Price;
        protected Currency Cost;
        protected uint Quantity;
        protected string Producer;
        protected float Weight;


        public Product() 
        {
            Name = string.Empty;
            Price = 0;
            Cost = new Currency();
            Quantity = 0;
            Producer = string.Empty;
            Weight = 0;
        }

        public Product(string Name, uint Price, string CurrencyName, float ExRate)
        {
            this.Name = Name;
            this.Price = Price;
            Cost = new Currency(CurrencyName, ExRate);
            Quantity = 1;
            Producer = string.Empty;
            Weight = 1;
        }

        public Product(string Name, uint Price, string CurrencyName, float ExRate, uint Quantity, string Producer, float Weight): this(Name, Price, CurrencyName, ExRate)
        {
            
            Cost = new Currency(CurrencyName, ExRate);
            this.Quantity = Quantity;
            this.Producer = Producer;
            this.Weight = Weight;
        }

        public Product(Product obj)
        {
            Name = obj.Name;
            Price = obj.Price;
            Cost= obj.Cost;
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;
        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public uint price
        {
            get { return Price; }
            set { Price = value; }
        }
        public Currency cost
        {
            get { return Cost; }
            set
            {
                Cost = new Currency();
            }
        }
        public uint quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public string producer
        {
            get { return Producer; }
            set { Producer = value; }
        }
        public float weight
        {
            get { return Weight; }
            set { Weight = value; }
        }


        public float GetPriceInUAH()
        {
            float price = 1;
            price *= Price * Cost.exRate;
            return price;
        }

        public float GetTotalPriceInUAH()
        {
            float price = 1;
            price *= Price * Cost.exRate * Quantity;
            return price;
        }

        public float GetTotalWeight()
        {
            float totalWeight = 1;
            totalWeight *= Quantity * Weight;
            return totalWeight;
        }

        public void GetTotalInfo() 
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price per 1: {Price}");
            Console.WriteLine($"Price in UAH: {GetPriceInUAH()}");
            Console.WriteLine($"Total price in UAH: {GetTotalPriceInUAH()}");
            Console.WriteLine($"Total weight: {GetTotalWeight()}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Producer: {Producer}");
        }





    }
}
