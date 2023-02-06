using System;

namespace OOP1
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;


        public string startCity { get => StartCity; set { StartCity = value; } }
        public string finishCity { get => FinishCity; set { FinishCity = value; } }
        public Date startDate { get => StartDate; set { StartDate = value; } }
        public Date finishDate { get => FinishDate; set { FinishDate = value; } }


        public Airplane(string StartCity, string FinishCity, Date StartDate, Date FinishDate)
        {
            startCity = StartCity;
            finishCity = FinishCity;
            startDate = StartDate;
            finishDate = FinishDate;
        }
        public Airplane(Date StartDate, Date FinishDate)
        {
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane()
        {
            StartCity = "";
            FinishCity = "";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(Airplane copyAirplane)
        {
            StartCity = copyAirplane.StartCity;
            FinishCity = copyAirplane.FinishCity;
            StartDate = copyAirplane.StartDate;
            FinishDate = copyAirplane.FinishDate;

        }
        public int GetTotalTime()

        {
            Date a = StartDate;
            Date b = FinishDate;
            int traveltime = b.TotalMin() - a.TotalMin();
            return traveltime;

        }
        public bool IsArrivingToday()
        {
            if (StartDate.day == FinishDate.day &&
                StartDate.year == FinishDate.year &&
                StartDate.month == FinishDate.month)
                return true;
            else return false;
        }
    }
        public class Date
        {
            protected int Year;
            protected int Month;
            protected int Day;
            protected int Hours;
            protected int Minutes;

            public int year { get => Year; set { Year = value; } }
            public int month { get => Month; set { Month = value; } }
            public int day { get => Day; set { Day = value; } }
            public int hours { get => Hours; set { Hours = value; } }
            public int minutes { get => Minutes; set { Minutes = value; } }

            public Date()
            {
            Year = 1970;
            Month = 1;
            Day = 1;
            Hours = 0;
            Minutes = 0;
            }
        public Date(Date copyDate)
        {
            Year = copyDate.Year;
            Month = copyDate.Month;
            Day = copyDate.Day;
            Hours = copyDate.Hours;
            Minutes = copyDate.Minutes;
        }
            public Date(int Year, int Month, int Day, int Hours, int Minutes)
            {
                year = Year;
                month = Month;
                day = Day;
                hours = Hours;
                minutes = Minutes;
            }
        public Date(int Year, int Month, int Day)
        {
            year = Year;
            month = Month;
            day = Day;
        }

        public int TotalMin()
            {
                int TotalMin1 = minutes;
                TotalMin1 += 60 * hours;
                TotalMin1 += 24 * 60 * day;
                TotalMin1 += 30 * 24 * 60 * month;
                TotalMin1 += 12 * 30 * 24 * 60 * year;
                return TotalMin1;

            }

        }
}
