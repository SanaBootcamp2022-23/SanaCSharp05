using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Airplane
    {
        protected string startCity;
        protected string finishCity;
        protected Date startDate;
        protected Date finishDate;

        public Airplane() { }

        public Airplane(string startcity, string finishcity, Date startdate, Date finishdate)
        {
            startCity = startcity;
            finishCity = finishcity;
            startDate = startdate;
            finishDate = finishdate;
        }

        public Airplane(Airplane obj)
        {
            startCity = obj.startCity;
            finishCity = obj.finishCity;
            startDate = obj.startDate;
            finishDate = obj.finishDate;
        }

        public Airplane(string startcity, string finishcity)
        {
            startCity = startcity;
            finishCity = finishcity;
        }

        public Airplane(Date startdate, Date finishdate)
        {
            startDate = startdate;
            finishDate = finishdate;
        }

        public string StartCity
        {
            get { return startCity; }
            set { if (value != "") startCity = value; }
        }

        public string FinishCity
        {
            get { return finishCity; }
            set { if (value != "") finishCity = value; }
        }

        public Date StartDate
        {
            get { return startDate; }
            set { startDate = new Date(value); }
        }

        public Date FinishDate
        {
            get { return finishDate; }
            set { finishDate = new Date(value); }
        }

        public double GetTotalTime(Date startdate, Date finishdate)
        {
            var difference = 
                new DateTime(startdate.Year, startdate.Month, startdate.Day, startdate.Hours, startdate.Minutes, 0) - 
                new DateTime(finishdate.Year,finishdate.Month, finishdate.Day, finishdate.Hours, finishdate.Minutes, 0);
            
            return difference.TotalMinutes;
        }

        public bool IsArrivingToday(Date startdate, Date finishdate)
        {
            return new DateTime(startdate.Year, startdate.Month, startdate.Day)
                .Equals(new DateTime(finishdate.Year, finishdate.Month, finishdate.Day));
        }
    }
}
