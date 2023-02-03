using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
	internal class Product
	{
		protected string _name;
		public string Name
		{
			get { return _name; }
			set
			{
				if (value != null && value != "")
				{
					_name = value;
				}
			}
		}

		protected double _price;
		public double Price
		{
			get { return _price; }
			set
			{
				if (value > 0)
				{
					_price = value;
				}
			}
		}

		protected int _quantity;
		public int Quantity
		{
			get { return _quantity; }
			set
			{
				if (value>=0) { 
					_quantity = value;
				}
			}
		}

		protected double _weigth;
		public double Weigth
		{
			get { return _weigth; }
			set
			{
				if (value > 0) { 
					_weigth = value;
				}
			}
		}

		protected Currency _currency;
		public Currency Currency
		{
			get { return _currency; }
			set { _currency = new Currency(value); }
		}

		public Product()
		{

		}
		public Product(string name, double price, int quantity, 
			double weight, Currency currency)
		{
			Name= name;
			Price= price;
			Quantity= quantity;
			Weigth= weight;
			Currency=new Currency(currency);
		}
		public Product(string name, int quantity, double weight)
		{
			Name = name;
			Quantity = quantity;
			Weigth = weight;
		}
		public Product(Product product)
		{
			Name= product.Name;
			Price = product.Price;
			Quantity = product.Quantity;
			Weigth = product.Weigth;
			Currency=new Currency(product.Currency);
		}

		public double GetPriceInUAH() => Price * Currency.ExRate;

		public double GetTotalPriceInUAH() => GetPriceInUAH()*Quantity;

		public double GetTotalWeight() => Quantity * Weigth;
		
	}
}
