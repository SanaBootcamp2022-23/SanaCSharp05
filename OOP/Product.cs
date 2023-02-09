using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Product
    {
        protected string Name = "NoName";
        protected decimal Price = 0;
        protected Currency Cost = new Currency();
        protected int Quantity = 0;
        protected string Produser = "NoName";
        protected decimal Weight = 0;
        public Product()
        {
            Name = "Noname";
            Price = 0;
            Cost = new Currency();
            Quantity = 0;
            Produser = "NoName";
            Weight = 0;
        }
        public Product(string name, decimal price, Currency cost, int quantity, string produser, decimal weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Produser = produser;
            Weight = weight;
        }
        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public Product(string produser, decimal weight)
        {
            Produser = produser;    
            Weight = weight;
        }
        public decimal GetPriceInUAH()
        {
            return Price * Cost.ExRate;
        }
        public decimal GetTotalPriceInUAH()
        {
            return Price * Cost.ExRate * Quantity;
        }
        public decimal GetTotalWeight()
        {
            return Weight * Quantity;
        }
        public override string ToString()
        {
            return $"Name : {Name}\n" +
                   $"Price : {Price}\n" +
                   $"{Cost.ToString()}\n" +
                   $"Quantity : {Quantity}\n" +
                   $"Producer : {Produser}\n" +
                   $"Weight : {Weight}\n" +
                   $"PriceInUAH : {GetPriceInUAH()}\n" +
                   $"TotalPriceInUAH : {GetTotalPriceInUAH()}\n" +
                   $"TotalWeight : {GetTotalWeight()}";
        }
        public void SetName(string name) { Name = name; }   
        public string GetName() { return Name; }
        public void SetPrice(decimal price) { Price = price; }
        public decimal GetPrice() { return Price; }
        public void SetCost(Currency cost) { Cost = cost; }  
        public Currency GetCost() { return Cost; }
        public void SetQuantity(int quantity) { Quantity = quantity; }
        public int GetQuantity() { return Quantity; }
        public void SetProduser(string produser) { Produser = produser; }
        public string GetProduser() { return Produser; }
        public void SetWeigth(decimal weight) { Weight = weight; }
        public decimal GetWeigth() { return Weight; }
    }
}
