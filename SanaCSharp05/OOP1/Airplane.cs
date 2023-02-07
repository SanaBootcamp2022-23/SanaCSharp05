using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        protected string startCity;
        public string StartCity
        {
            get; set;
        }
        protected string finishCity;
        public string FinishCity
        {
            get; set;
        }
        protected Date startDate = new Date();
        public Date StartDate
        {
            get; set;
        }
        protected Date finishDate = new Date();
        public Date FinishDate
        {
            get; set;
        }
        public Airplane()
        {
            StartCity = "Kyiv";
            FinishCity = "Warsaw";
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane (string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }


        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = airplane.StartDate;
            FinishDate = airplane.FinishDate;
        }

        public int GetTotalTime()
        {
            return (int)new DateTime(this.FinishDate.Year, this.FinishDate.Month, this.FinishDate.Day,
                                      this.FinishDate.Hours, this.FinishDate.Minutes, 0).Subtract
                                      (new DateTime(this.StartDate.Year, this.StartDate.Month, this.StartDate.Day,
                                      this.StartDate.Hours, this.StartDate.Minutes, 0)).TotalMinutes;
        }
        public bool? IsArrivingToday()
        {
            if (StartDate.Year == FinishDate.Year && StartDate.Month == FinishDate.Month && StartDate.Day == FinishDate.Day)
                return true;
            return false;
        }

    }
}
