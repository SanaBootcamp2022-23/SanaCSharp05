using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        private string _name;
        private int _price;
        private Currency _cost;
        private int _quantity;
        private string _producer;
        private int _weight;
    
        public Product()
        {
            Name= "";
            Price= 1;
            Cost = new Currency();
            Quantity= 1;
            Producer = "";
            Weight = 1;
        }    

        public Product( string name,int price,Currency cost,int quantity,string producer, int weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;

        }   
        public Product(Product CopyProduct)
        {
            Name = CopyProduct.Name;
            Price = CopyProduct.Price;
            Cost = CopyProduct.Cost;
            Quantity = CopyProduct.Quantity;
            Producer = CopyProduct.Producer;
            Weight = CopyProduct.Weight;

        }

        public double GetPriceInUAH()
        {
            return Price*Cost.ExRate;
        }

        public double GetTotalPriceInUAH()
        {
            return Quantity*GetPriceInUAH();
        }
        public double GetTotalWeight()
        {
            return Weight*Quantity;
        }
        public void PrintProd()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
            Cost.PrintCost();
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Producer: " + Producer);
            Console.WriteLine("Weight: " + Weight);
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Price
        {
            get 
            {

                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Неправильне введення");
                }
                _price = value; 
            }
        }

        public Currency Cost
        {
            get
            {
                return _cost;
            }
            set
            {

                _cost = value;
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Неправильне введення");
                }
                _quantity = value;
            }
        }
        public string Producer
        {
            get
            {
                return _producer;
            }
            set
            {
                _producer = value;
            }   
        }
        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Неправильне введення");
                }
                _weight = value;
            }
        }

    }
}
