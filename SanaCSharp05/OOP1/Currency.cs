namespace OOP1
{
	internal class Currency
	{
		protected string _name;
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (value != null && value != "")
				{
					_name = value;
				}
			}
		}
		protected double _exRate;
		public double ExRate
		{
			get { return _exRate; }
			set
			{
				if(value>=0) { 
					_exRate = value;
				}
			}
		}


		public Currency()
		{

		}

		public Currency(string name, double exRate)
		{
			Name = name;
			ExRate = exRate;
		}

		public Currency(string name)
		{
			Name = name;
		}

		public Currency(Currency currency)
		{
			_name = currency.Name;
			_exRate = currency.ExRate;
		}
	}
}
