using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOP1.Date;
using static OOP1.Display;


namespace OOP1
{
    public class Airplane
    {
        protected string _startCity = "Kyiv";
        public string StartCity
        {
            set { 
                if (value != null && value != "") 
                {
                    _startCity = value;
                }
            }
            get { return _startCity; }
        }

        protected string _finishCity = "Wroclaw";
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

        protected Date? _startDate = new Date();
        public Date? StartDate
        {
            set
            {
                Date _startDate = new Date();
            }
            get { return _startDate; }
        }

        protected Date? _finishDate = new Date();
        public Date?  FinishDate
        {
            set
            {
                Date _finishDate = new Date();
            }
            get { return _finishDate; }

        }
        public Airplane() {}
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            Date StartDate = new Date(startDate);
            Date FinishDate = new Date(finishDate);
        } 
        public Airplane(string startCity, string finishCity) 
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }
        public Airplane(string finishCity) 
        {
            FinishCity = finishCity;
        }
        public Airplane(Airplane airplane)
        {
            StartCity = airplane._startCity;
            FinishCity = airplane._finishCity;
            StartDate = airplane._startDate;
            FinishDate = airplane._finishDate;
        }
        public int GetTotalTime()
        {
            return (int)new DateTime(this.FinishDate.Year, this.FinishDate.Month, this.FinishDate.Day,
                                      this.FinishDate.Hour, this.FinishDate.Minutes, 0)
                            .Subtract(
                         new DateTime(this.StartDate.Year, this.StartDate.Month, this.StartDate.Day,
                                      this.StartDate.Hour, this.StartDate.Minutes, 0)).TotalMinutes;
        }
            public bool IsArrivingToday()
        {
            if
            (
                StartDate.Year == FinishDate.Year &&
                StartDate.Month ==FinishDate.Month &&
                StartDate.Day == FinishDate.Day
            ) { return true; }
            return false;
        }
        
    }
}
