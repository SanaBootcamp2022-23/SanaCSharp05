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
				if (value >= 0)
				{
					_quantity = value;
				}
			}
		}

		protected string _producer;
		public string Producer
		{
			get { return _producer; }
			set
			{
				if (value != null && value != "")
				{
					_producer = value;
				}
			}
		}

		protected double _weigth;
		public double Weigth
		{
			get { return _weigth; }
			set
			{
				if (value > 0)
				{
					_weigth = value;
				}
			}
		}

		protected Currency _currency;
		public Currency Currency
		{
			get { return new Currency(_currency); }
			set { _currency = new Currency(value); }
		}

		public Product()
		{

		}
		public Product(string name, double price, int quantity,
			string producer, double weight, Currency currency)
		{
			Name = name;
			Price = price;
			Quantity = quantity;
			Producer = producer;
			Weigth = weight;
			Currency = new Currency(currency);
		}
		public Product(string name, int quantity, double weight)
		{
			Name = name;
			Quantity = quantity;

			Weigth = weight;
		}
		public Product(Product product)
		{
			Name = product.Name;
			Price = product.Price;
			Quantity = product.Quantity;
			Producer = product.Producer;
			Weigth = product.Weigth;
			Currency = new Currency(product.Currency);
		}

		public double GetPriceInUAH() => Price * Currency.ExRate;
		
		public double GetTotalPriceInUAH() => GetPriceInUAH() * Quantity;

		public double GetTotalWeight() => Quantity * Weigth;

	}
}
