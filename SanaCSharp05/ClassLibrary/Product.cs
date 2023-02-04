using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product
    {
        protected string name = "Unknown";
        protected double price = 0;
        protected int quantity = 0;
        protected string producer = "Unknown";
        protected double weight = 0;
        public Currency Cost { get; set; } = new Currency();
        public string Name { get { return name; } set { if (value.Length > 0) name = value; } }
        public double Price { get { return price; } set {if (value > 0.0) price = value; } }
        public int Quantity { get { return quantity; } set {if (value >= 0) quantity = value; } }
        public string Producer { get { return producer; } set {if (value.Length > 0) producer = value; } }
        public double Weight { get { return weight; } set { if (value > 0.0) weight = value; } }

        public Product()
        {

        }

        public Product(string productName, double productPrice, Currency currencyCost, int productQuantity)
        {
            Name = productName;
            Price = productPrice;
            Cost = new Currency(currencyCost);
            Quantity = productQuantity;
        }

        public Product(string productName, double productPrice, Currency currencyCost, int productQuantity, string productProducer, double productWeight) 
            : this(productName, productPrice, currencyCost, productQuantity)
        {
            Producer = productProducer;
            Weight = productWeight;
        }

        public Product(Product product) 
            : this(product.Name, product.Price, product.Cost, product.Quantity, product.Producer, product.Weight)
        {

        }

        public double GetPriceInUAH()
        {
            return Math.Round(Cost.ExRate * Price, 2);
        }

        public double GetTotalPriceInUAH()
        {
            return Math.Round(Cost.ExRate * Price * Quantity, 2);
        }

        public double GetTotalWeight()
        {
            return Math.Round(Weight * Quantity, 3);
        }
    } 
}
