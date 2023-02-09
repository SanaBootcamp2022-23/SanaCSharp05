using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        private string Name = "Unknown";
        private int Price = 0;
        private int Quantity = 0;
        private string Producer = "Unknown";
        private int Weight = 0;
        private Currency Cost;

        public Product(string name, int price, int quantity, string producer, int weight, Currency cost)
        {
            if (name.Length > 0) { Name = name; }
            if (price > 0) { Price = price; }
            if (quantity > 0) { Quantity = quantity; }
            if (producer.Length > 0) { Producer = producer; }
            if (weight > 0) { Weight = weight; }
            Cost = new Currency(cost);
        }

        public Product(string name, string producer)
        {
            if (name.Length > 0) { Name = name; }
            if (producer.Length > 0) { Producer = producer; }
        }

        public Product()
        {
        }

        public Product(Product product)
        {
            this.Name = product.Name;
            this.Price = product.Price;
            this.Quantity = product.Quantity;
            this.Producer = product.Producer;
            this.Weight = product.Weight;
            this.Cost = product.Cost;
        }

        public string name
        {
            private set { Name = value; }
            get { return Name; }
        }

        public int price
        {
            private set { Price = value; }
            get { return Price; }
        }

        public int quantity
        {
            private set { Quantity = value; }
            get { return Quantity; }
        }
        public string producer
        {
            private set { Producer = value; }
            get { return Producer; }
        }
        public int weight
        {
            private set { Weight = value; }
            get { return Weight; }
        }
        public Currency cost
        {
            private set { Cost = value; }
            get { return Cost; }
        }
        public string currencyName
        {
            get { return Cost.name; }
        }
        public double currencyExRate
        {
            get { return Cost.exRate; }
        }

        public double GetPriceInUAH()
        {
            return price*Cost.exRate;
        }
        public double GetTotalPriceInUAH()
        {
            return price * Cost.exRate*quantity;
        }
        public double GetTotalWeight()
        {
            return weight * quantity;
        }
    }
}
