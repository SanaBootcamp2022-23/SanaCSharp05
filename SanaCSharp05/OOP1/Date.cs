using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Date
    {
        private int Year;
        private int Month;
        private int Day;
        private int Hour;
        private int Minute;

        public Date()
        {
            Year = 2023;
            Month = 1;
            Day = 1;
            Hour = 1;
            Minute = 1;
        }

        public Date(int year, int month, int day, int hour, int minute)
        {
            if(year==2023) Year = year;
                else Console.WriteLine("Введіть поточний рік");

            if (month > 0 && month <= 12) Month = month;
                else Console.WriteLine("Некоректно введені данні - month");

            if (day > 0 && day <= 31) Day = day;
                else Console.WriteLine("Некоректно введені данні - day");

            if (hour > 0 && hour <= 24) Hour = hour;
                else Console.WriteLine("Некоректно введені данні - hour");

            if (minute > 0 && minute <= 60) Minute = minute;
                else Console.WriteLine("Некоректно введені данні - minute");
        }

        public Date(int year, int month, int day)
        {
            if (year == 2023) Year = year;
            else Console.WriteLine("Введіть поточний рік");

            if (month > 0 && month <= 12) Month = month;
            else Console.WriteLine("Некоректно введені данні - month");

            if (day > 0 && day <= 31) Day = day;
            else Console.WriteLine("Некоректно введені данні - day");
        }

        public Date(Date obj)
        {
            this.Day = obj.Day;
            this.Hour = obj.Hour;
            this.Minute = obj.Minute;
            this.Year = obj.Year;
            this.Month = obj.Month;
        }

        public int year
        {
            private set { if (value == 2023) Year = value; }
            get { return Year; }
        }
        public int month
        {
            private set { if (value > 0 && value <= 12) Month = value; }
            get { return Month; }
        }
        public int day
        {
            private set { if (value > 0 && value <= 31) Day = value; }
            get { return Day; }
        }
        public int hour
        {
            private set { if (value > 0 && value <= 24) Hour = value; }
            get { return Hour; }
        }
        public int minute
        {
            private set { if (value > 0 && value <= 60) Minute = value; }
            get { return Minute; }
        }
    }
}
