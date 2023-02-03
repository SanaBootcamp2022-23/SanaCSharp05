using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
	internal class Date
	{
		protected int[] numOfDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

		protected int _year;
		public int Year
		{
			set { 
				if(value >= 1900 && value <= 2100)
				{
					_year = value;
				}
			}
			get { return _year; }
		}

		protected int _month =0;
		public int Month
		{
			set
			{
				if(value>=1 && value <= 12)
				{
					_month = value;
				}
			}
			get { return _month; }
		}

		protected int _day;
		public int Day
		{
			set
			{
				numOfDays[1] += isLeapYear();

				if(value>=1 && value <= numOfDays[Month - 1])
				{
					_day = value;
				}
			}
			get { return _day; }
		}

		protected int _hour;
		public int Hour
		{
			set
			{
				if (value >= 1 && value <= 24)
				{
					_hour = value;
				}
			}
			get { return _hour; }
		}

		protected int _minutes;
		public int Minutes
		{
			set
			{
				if (value >= 0 && value <= 59)
				{
					_minutes = value;
				}
			}
			get { return _minutes; }
		}


		public Date(int year, int month, int day, int hour, int minutes)
		{
			Year = year;
			Month = month;
			Day = day;
			Hour = hour;
			Minutes = minutes;
		}
		public Date(int year, int month, int day, int hour)
		{
			Year = year;
			Month = month;
			Day = day;
			Hour = hour;
		}
		public Date(int year, int month, int day)
		{
			Year = year;
			Month = month;
			Day = day;
		}

		public Date(Date date)
		{
			Year = date.Year;
			Month = date.Month;
			Day = date.Day;
			Hour = date.Hour;
			Minutes = date.Minutes;
		}

		public Date()
		{

		}

		// Converting Days to minutes
		public static int DaysToMinutes(int days) => days*24*60;

		// Return 1 if year is leap, 0 if year is not leap
		public int isLeapYear()
		{
			return (Year % 400 == 0 || Year % 100 != 0)
				&& Year % 4 == 0 ? 1 : 0;
		}

		private int _GetDays()
		{
			
			int totalDays = 0;
			for (int monthNum = 1; monthNum < Month; monthNum++)
			{
				totalDays += numOfDays[monthNum-1];
			}
			totalDays += Day;
			return totalDays;
		}
		public int GetMinutes()
		{
			int totalMinutes = _GetDays() * 24 * 60;
			totalMinutes += Hour * 60;
			totalMinutes += Minutes;
			return totalMinutes;
		}
	}
}
