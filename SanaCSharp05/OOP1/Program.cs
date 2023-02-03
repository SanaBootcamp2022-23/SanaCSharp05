using System.Text;

namespace OOP1
{
	
	internal class Program
	{
		static void PrintDate(Date date)
		{
			Console.WriteLine("{0}.{1}.{2} {3}:{4}",
				date.Day, date.Month, date.Year, date.Hour, date.Minutes);
			
		}
		static void PrintAirplane(Airplane airplane) 
		{
			Console.WriteLine(airplane.StartCity);
			Console.WriteLine(airplane.FinishCity);
			PrintDate(airplane.StartDate);
			PrintDate(airplane.FinishDate);
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
			Console.WriteLine("Second plane:");
			PrintAirplane(airplane2);
			Console.WriteLine(airplane2.GetTotalTime());

			Console.WriteLine("----------------------------");

			if ((bool)(1))
			{
				Console.WriteLine("2");
			}
		}
	}
}