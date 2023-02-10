using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP1
{
    public class Product
    {
        private string Name = "Unknown";
        private int Price = 1;
        private int Quantity = 1;
        private string Producer = "Unknown";
        private int Weight = 1;
        private Currency Cost;

        public Product (string name, int price, int quantity, string producer, int weight, Currency cost)
        {
            if (name.Length>0) { Name = name; }
            if (price > 0) { Price = price; }
            if (quantity > 0) { Quantity = quantity; }
            if (producer.Length > 0) { Producer = producer; }
            if (weight>0) { Weight = weight; }
            Cost = new Currency(cost);
        }
        public Product() { }
        public Product(string name, int price, int quantity, int weight, Currency cost)
        {
            if (name.Length > 0) { Name = name; }
            if (price > 0) { Price = price; }
            if (quantity > 0) { Quantity = quantity; }
            if (weight > 0) { Weight = weight; }
            Cost = new Currency(cost);
        }
        public Product(Product product) 
        {
            if (product.Name.Length > 0) { Name = product.Name; }
            if (product.Price > 0) { Price = product.Price; }
            if (product.Quantity > 0) { Quantity = product.Quantity; }
            if (product.Producer.Length > 0) { Producer = product.Producer; }
            if (product.Weight > 0) { Weight = product.Weight; }
            Cost = new Currency(product.Cost);
        }

        public string name
        {
            set { Name = value; }
            get { return Name; }
        }
        public int price
        {
            set { Price = value; }
            get { return Price; }
        }
        public int quantity
        {
            set { Quantity = value; }
            get { return Quantity; }
        }
        public string producer
        {
            set { Producer = value; }
            get { return Producer; }
        }
        public int weight
        {
            set { Weight = value; }
            get { return Weight; }
        }
        public Currency cost
        {
            set { Cost = value; }
            get { return Cost; }
        }

        public double GetPricelnUAH() 
        {
            double getpricelnuah = (double)price*Cost.GetExRate();
            return getpricelnuah;
        }
        public double GetTotalPricelnUAH()
        {
            return (double)price * Cost.GetExRate() * quantity;
        }
        public double GetTotalWeight()
        {
            return weight*quantity;
        }

    }
}
