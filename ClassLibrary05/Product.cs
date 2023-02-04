using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;

namespace ClassLibrary05
{
    public class Product
    {
        protected string Name { get; set; }
        protected double Price { get; set; }
        protected Currency Cost { get; set; }
        protected int Quantity { get; set; }
        protected string Producer { get; set; }
        protected double Weight { get; set; }

        public Product(Product PrevProduct)
        {
            Name = PrevProduct.Name;
            Price = PrevProduct.Price;
            Cost = PrevProduct.Cost;
            Quantity = PrevProduct.Quantity;
            Producer = PrevProduct.Producer;
            Weight = PrevProduct.Weight;
        }

        public Product()
        {
            Name = "";
            Price = 0.00;
            Cost = new Currency();
            Quantity = 0;
            Producer = "";
            Weight = 0.00;
        }

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public void SetName(string name) => Name = name;
        public void SetPrice(double price)
        {
            if (price < 0)
                price = 0;
            
            Price = price;
        }
        public void SetCost(Currency cost) => Cost = cost;
        public void SetQuantity(int quantity) => Quantity = quantity;
        public void SetProducer(string producer) => Producer = producer;
        public void SetWeight(double weight) => Weight = weight;
        public string GetName() => Name;
        public double GetPrice() => Price;
        public Currency GetCost() => Cost;
        public int GetQuantity() => Quantity;
        public string GetProducer() => Producer;
        public double GetWeight() => Weight;
        
        public double GetPriceInUAH() => Price * Cost.GetExRate();

        public double GetTotalPriceInUAH() => GetPriceInUAH() * Quantity;

        public double GetTotalWeight() => Weight * Quantity;
    }
}
