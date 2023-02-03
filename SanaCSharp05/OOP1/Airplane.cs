namespace OOP1
{
	internal class Airplane
	{
		protected string _startCity;
		public string StartCity
		{
			set
			{
				if (value != null && value != "")
				{
					_startCity = value;
				}
			}
			get { return _startCity; }
		}

		protected string _finishCity;
		public string FinishCity
		{
			set
			{
				if (value != null && value != "")
				{
					_finishCity = value;
				}
			}
			get { return _finishCity; }
		}

		protected Date _startDate;
		public Date StartDate
		{
			set
			{
				_startDate = new Date(value);
			}
			get { return _startDate; }
		}

		protected Date _finishDate;
		public Date FinishDate
		{
			set
			{
				_finishDate = new Date(value);
			}
			get { return _finishDate; }

		}

		public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
		{
			StartCity = startCity;
			FinishCity = finishCity;
			StartDate = new Date(startDate);
			FinishDate = new Date(finishDate);
		}
		public Airplane(string startCity, string finishCity)
		{
			StartCity = startCity;
			FinishCity = finishCity;
		}
		public Airplane()
		{

		}

		
		
		public int GetTotalTime()
		{
			// Перевірка правильності відповіді засобами .NET
			/* DateTime time1 = new DateTime(StartDate.Year, StartDate.Month,
				StartDate.Day, StartDate.Hour, StartDate.Minutes, 0);
			DateTime time2 = new DateTime(FinishDate.Year, FinishDate.Month,
				FinishDate.Day, FinishDate.Hour, FinishDate.Minutes, 0);

			Console.WriteLine("-----------------------------");
			Console.WriteLine(time1.ToString("MM/dd/yyyy HH:mm"));
			Console.WriteLine(time2.ToString("MM/dd/yyyy HH:mm"));

			Console.WriteLine("\nПравильна відповідь: ");
			Console.WriteLine((time2.Subtract(time1)).TotalMinutes.ToString());
			Console.WriteLine("-----------------------------"); */


			int totalTime = 0;
			if (StartDate.Year == FinishDate.Year)
			{
				totalTime = FinishDate.GetMinutes() - StartDate.GetMinutes();
			}
			else
			{
				totalTime = Date.DaysToMinutes(365 + StartDate.isLeapYear())
					- StartDate.GetMinutes() + FinishDate.GetMinutes(); 
			}
			//Console.WriteLine(totalTime);
			return totalTime;
		}

		public bool isArrivingToday()
		{
			if (StartDate.Year == FinishDate.Year &&
				StartDate.Month == FinishDate.Month &&
				StartDate.Day == FinishDate.Day)
				return true;
			return false;
		}
	}
}
