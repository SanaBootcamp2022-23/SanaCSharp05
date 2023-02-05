using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        protected string Name = "";
        protected string Producer = "";
        protected Currency Cost;
        protected double Price;
        protected int Quantity;
        protected double Weight;

        public string Name_
        {
            get { return Name; }
            set { if (!string.IsNullOrEmpty(value)) Name = value; }
        }
        public string Producer_
        {
            get { return Producer; }
            set { if (!string.IsNullOrEmpty(value)) Producer = value; }
        }
        public Currency Cost_
        {
            get { return Cost; }
            set { Cost = value; }
        }
        public double Price_
        {
            get { return Price; }
            set { Price = value; }
        }
        public int Quantity_
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public double Weight_
        {
            get { return Weight; }
            set { Weight = value; }
        }
        public Product()
        {
            Cost = Currency.Default;
        }
        public Product(string name, string producer, Currency cost, double price, int quantity, double weight)
        {
            Name = name;
            Producer = producer;
            Cost = cost;
            Price = price;
            Quantity = quantity;
            Weight = weight;
        }
        public Product(string name, string producer)
        {
            Name = name;
            Producer = producer;
            Cost = Currency.Default;
        }
        public Product(Product PreviousProduct)
        {
            Name = PreviousProduct.Name;
            Producer = PreviousProduct.Producer;
            Cost = PreviousProduct.Cost;
            Price = PreviousProduct.Price;
            Quantity = PreviousProduct.Quantity;
            Weight = PreviousProduct.Weight;
        }
        public Product Copy()
        {
            return new(this);
        }
        public void Show()
        {
            Console.WriteLine("Name:               " + Name);
            Console.WriteLine("Producer:           " + Producer);
            Console.WriteLine("Cost:               " + Cost.ExRate_ + "(" + Cost.Name_ + ")");
            Console.WriteLine("Price:              " + Price);
            Console.WriteLine("Quantity:           " + Quantity);
            Console.WriteLine("Weight:             " + Weight);
            Console.WriteLine("Price in UAH:       " + (float)GetPriceInUAH());
            Console.WriteLine("Total price in UAH: " + (float)GetTotalPriceInUAH());
            Console.WriteLine("Total weight:       " + (float)GetTotalWeight());
        }
        public double GetPriceInUAH()
        {
            return Price_ * Cost.ExRate_;
        }

        public double GetTotalPriceInUAH()
        {
            return Quantity_ * Price_ * Cost.ExRate_;
        }

        public double GetTotalWeight()
        {
            return Quantity_ * Weight_;
        }

    }
}
