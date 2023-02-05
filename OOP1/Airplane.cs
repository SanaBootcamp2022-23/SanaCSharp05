using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        protected string _startcity = "Kiev";
        protected string _finishcity = "London";
        protected Date _startdate = new Date();
        protected Date _finishdate = new Date();
        public Airplane()
        {

        }
        public Airplane(string startcity, string finishcity)
        {
            StartCity = startcity;
            FinishCity = finishcity;
        }
        public Airplane(string startcity, string finishcity, Date startdate, Date finishdate)
        {
            StartCity = startcity;
            FinishCity = finishcity;
            StartDate = new Date(startdate);
            FinishDate = new Date(finishdate); ;
        }
        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = new Date(airplane.StartDate);
            FinishDate = new Date(airplane.FinishDate);
        }
        public string StartCity
        {
            set; get;
        }
        public string FinishCity
        {
            set; get;
        }
        public Date StartDate
        {
            set; get;
        }
        public Date FinishDate
        {

            set; get;
        }
        public double GetTotalTime()
        {
            TimeSpan ts = FinishDate.FullDate() - StartDate.FullDate();
            return ts.TotalMinutes;

        }
        public bool IsArrivingToday()
        {
            return StartDate.Year == FinishDate.Year && StartDate.Month == FinishDate.Month && StartDate.Day == FinishDate.Day;

        }
    }
}
