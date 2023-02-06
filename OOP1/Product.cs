using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        private string Name { get; set; } = "Unknown name";
        private double Price { get; set; } = 0;
        private int Quantity { get; set; } = 0;
        private double Weight { get; set; } = 0;
        private string Producer { get; set; } = "Unknown producer";
        Currency Cost { get; set; } = new Currency();


        public Product()
        {

        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price; 
        }
        public Product(string name, double price, int quantity, double weight, string producer, Currency cost)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Weight = weight;
            Producer = producer;
            Cost = cost; 
        }
        public double GetPriceInUAH() 
        {
            return Price*Cost.ExRate;
        }
        public double GetTotalPriceInUAH() 
        {
            double totalPrice = (Price * Quantity)*Cost.ExRate;
            return totalPrice;
        }
        public double GetTotalWeight() 
        {
            return Weight * Cost.ExRate;
        }
    }
}
