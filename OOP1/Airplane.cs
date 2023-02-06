using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Airplane
    {
        private Date StartDate { get; set; } = new Date();
        private Date FinishDate { get; set; } = new Date();

        private string StartCity { get; set; } = "StartCiy";
        private string FinishCity { get; set; } = "FinishCity";
        public Airplane()
        {

        }
        public Airplane(Date startDate, string startCity)
        {
            StartCity = startCity;
            StartDate = startDate;
        }

        public Airplane(Date startDate, Date finishDate, string finishCity, string startCity)
        {
            StartCity = startCity;
            StartDate = startDate;
            FinishDate = finishDate;
            FinishCity = finishCity;
        }
        public double GetTotalTime()
        {
            DateTime start = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartDate.Hours, StartDate.Minutes, 0);
            DateTime finish = new DateTime(FinishDate.Year, FinishDate.Month, FinishDate.Day, FinishDate.Hours, FinishDate.Minutes, 0);

            TimeSpan interval = finish - start;

            return interval.TotalMinutes;

        }
        public bool IsArrivingToday() 
        {
            return StartDate.Day == FinishDate.Day && StartDate.Month == FinishDate.Month && StartDate.Year == FinishDate.Year;
        }
    }
}
    