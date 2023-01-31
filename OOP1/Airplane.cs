using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP1;

namespace OOP1
{
    public class Airplane
    {
        protected string startCity;
        protected string finishCity;
        protected Date startDate;
        protected Date finishDate;

        public Date StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public Date FinishDate
        {
            get { return finishDate; }
            set
            {
                if (value.Year >= startDate.Year)
                    finishDate = value;
            }
        }

        public string StartCity
        {
            get { return startCity; }

            set
            {
                if (value != "")
                    startCity = value;
                else
                    throw new ArgumentException("Incorrect name of city");
            }
        }
        public string FinishCity
        {
            get { return finishCity; }

            set
            {
                if (value != "")
                    finishCity = value;
                else
                    throw new ArgumentException("Incorrect name of city");
            }
        }

        public Airplane()
        {
            StartCity = "Ukraine";
            FinishCity = "Ukraine";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(string startCity, string finishCity, Date startDate) : this(startCity, finishCity)
        {
            StartDate = startDate;
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate) : this(startCity, finishCity, startDate)
        {
            FinishDate = finishDate;
        }
        public Airplane(Airplane obj)
        {
            startCity = obj.startCity;
            finishCity = obj.finishCity;
            startDate = obj.startDate;
            finishDate = obj.finishDate;
        }

        public double GetTotalTime()
        {
            return (new DateTime(finishDate.Year, finishDate.Month, finishDate.Day, finishDate.Hours, finishDate.Minutes, 0) -
                new DateTime(startDate.Year, startDate.Month, startDate.Day, startDate.Hours, startDate.Minutes, 0)).TotalMinutes;
        }
        public bool IsArrivingToday()
        {
            return GetTotalTime() < 1440;
        }
    }
}
