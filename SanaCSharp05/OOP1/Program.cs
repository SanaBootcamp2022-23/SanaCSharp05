using System.Text;

namespace OOP1
{
	
	internal class Program
	{
		static void PrintDate(Date date)
		{
			Console.WriteLine("{0,2:d2}.{1,2:d2}.{2,2:d2} {3,2:d2}:{4,2:d2}",
				date.Day, date.Month, date.Year, date.Hour, date.Minutes);
			
		}
		static void PrintAirplane(Airplane airplane) 
		{
			Console.WriteLine("Start city: "+airplane.StartCity);
			Console.WriteLine("Finish city: "+airplane.FinishCity);
			Console.Write("Start date: "); PrintDate(airplane.StartDate);
			Console.Write("Finish date: "); PrintDate(airplane.FinishDate);
		}
		static void PrintCurrency(Currency currency)
		{
			Console.WriteLine("Cost: {0} {1}", currency.ExRate,currency.Name);
		}
		static void PrintProduct(Product product)
		{
			Console.WriteLine("Name: {0}",product.Name);
			Console.WriteLine("Price: {0}", product.Price);
			PrintCurrency(product.Currency);
			Console.WriteLine("Quantity: {0}", product.Quantity);
			Console.WriteLine("Producer: {0}",product.Producer);
			Console.WriteLine("Weight: {0}",product.Weigth);
		}

		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.UTF8;
			Console.OutputEncoding = Encoding.UTF8;

			Date date1 = new Date();
			date1.Year = 2002;
			date1.Month = 1;
			date1.Day = 31;
			date1.Hour = 23;
			date1.Minutes = 0;


			Airplane airplane1=new Airplane("London","Kyiv");
			airplane1.StartDate = new Date(date1);
			date1.Month = 2; date1.Day = 1; date1.Hour=2; date1.Minutes = 30;
			airplane1.FinishDate = new Date(date1);
			Airplane airplane2=new Airplane("1","1", 
				new Date(2000,12,30,12,0),
				new Date(2001,1,1,13,00));


			Console.WriteLine("First plane:");
			PrintAirplane(airplane1);
			Console.WriteLine("\nSecond plane:");
			PrintAirplane(airplane2);

			Console.WriteLine("*************");

			Console.Write("Total time of flight of first airplane: ");
			Console.WriteLine(airplane1.GetTotalTime());
			Console.Write("Total time of flight of second airplane: ");
			Console.WriteLine(airplane2.GetTotalTime());
			Console.WriteLine("*************");

			Console.Write("Is taking off at same day as arrival, first plane: ");
			Console.WriteLine(airplane1.isArrivingToday());
			Console.Write("Is taking off at same day as arrival, second plane: ");
			Console.WriteLine(airplane2.isArrivingToday());

			Console.WriteLine("----------------------------");
			
			Product product1 = new Product("Notebook 16", 999.5, 
				50, "Lenovo", 1.005, new Currency("USD", 36.5));

			PrintProduct(product1);

			Console.Write($"Get price of \"{product1.Name}\" in ua: {product1.GetPriceInUAH(),3:f3}");
			Console.WriteLine();
			Console.Write($"Get total price of \"{product1.Name}\" in ua: {product1.GetTotalPriceInUAH(),3:f3}");
			Console.WriteLine();
			Console.WriteLine($"Get total weight of all \"{product1.Name}\" in stock: {product1.GetTotalWeight(),3:f3}");



		}
	}
}