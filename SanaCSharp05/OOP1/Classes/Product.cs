using OOP1.MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Classes
{
    public class Product
    {
        private string name;
        private float price;
        private Currency cost;
        private string producer;
        private float weight;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Price
        {
            get { return price; }
            set {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Price must be greater than 0.", nameof(Price));
                }
            }
        }
        public Currency Cost
        {
            get { return cost; }
            set
            {
                cost = value;
            }
        }
        public string Producer
        {
            get { return producer; }
            set
            {
                producer = value;
            }
        }
        public float Weight
        {
            get { return weight; }
            set
            {
                weight = value;
            }
        }
        public Product() 
        {
            Name = string.Empty;
            Price = 0;
            Cost = new Currency();
            Producer = string.Empty;
            Weight = 0;
        }
        public Product(string name, float price, Currency cost, string producer, float weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Producer = producer;
            Weight = weight;
        }
        public Product(string name, float price)
        {
            Name = name;
            Price = price;
            Cost = new Currency();
            Producer = string.Empty;
            Weight = 0;
        }
        public Product(Currency cost, string producer, float weight)
        {
            Name = string.Empty;
            Price = 0;
            Cost = cost;
            Producer = producer;
            Weight = weight;
        }

        public float GetPriceInUAH()
        {
            if(cost.Name != "UAH")
            {
                return price * cost.ExRate;
            }

            return price;
        }
        public float GetTotalPriceInUAH(Product[] products)
        {
            float sum = 0;
            foreach (var product in products)
            {
                if (product.Cost.Name != "UAH")
                {
                    sum += product.Price * product.Cost.ExRate;
                }
                else
                {
                    sum += product.Price;
                }
            }
            return sum;
        }
        public float GetTotalWeight(Product[] products)
        {
            float sumWeight = 0;
            foreach (var product in products)
            {
                sumWeight += product.Weight;
            }
            return sumWeight;
        }
    }
}
