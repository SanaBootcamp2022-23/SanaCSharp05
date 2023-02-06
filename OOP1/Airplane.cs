using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        public string StartCity { get; set; }
        public string FinishCity { get; set; }
        public Date StartDate { get; set; }
        public Date FinishDate { get; set; }
        public Airplane()
        {
            StartCity = "undefined";
            FinishCity = "undefined";
            StartDate = new Date();
            FinishDate = new Date();
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
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(string startCity, string finishCity, Date startDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new Date(startDate);
            FinishDate = new Date();
        }
        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = new Date(airplane.StartDate);
            FinishDate = new Date(airplane.FinishDate);
        }
        public int GetTotalTime()
        {
            int totalMinutes = 0;
            int daysInMonth = DateTime.DaysInMonth(StartDate.Year, StartDate.Month);
            if (FinishDate.Month == StartDate.Month && FinishDate.Day > StartDate.Day)
            {
                totalMinutes = (FinishDate.Day - StartDate.Day) * 1440 + (FinishDate.Hours - StartDate.Hours) * 60 +
                    (FinishDate.Minutes - StartDate.Minutes);

            }
            else if (FinishDate.Month - StartDate.Month == 1)
            {
                totalMinutes = (FinishDate.Day + (daysInMonth - StartDate.Day)) * 1440 + (FinishDate.Hours - StartDate.Hours) * 60 +
                    (FinishDate.Minutes - StartDate.Minutes);
            }
            else if (FinishDate.Year > StartDate.Year && FinishDate.Month == 1 && StartDate.Month == 12)
            {
                totalMinutes = (FinishDate.Day + (daysInMonth - StartDate.Day)) * 1440 + (FinishDate.Hours - StartDate.Hours) * 60 +
                    (FinishDate.Minutes - StartDate.Minutes);
            }
            return totalMinutes;
        }
        public bool IsArrivingToday()
        {
            return StartDate.Day == FinishDate.Day && StartDate.Month == FinishDate.Month && StartDate.Year == FinishDate.Year;
        }
    }
}
