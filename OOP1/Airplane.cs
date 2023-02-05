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
        protected string finishCity;
        protected Date startDate;
        protected Date finishDate;

        public string StartCity 
        {
            get { return startCity;}
            set { startCity = value;}  
        }
        public string FinishCity
        {
            get { return finishCity;}
            set { finishCity = value;}
        }
        public Date StartDate
        {
            get { return startDate;}
            set { startDate = value;}
        }
        public Date FinishDate
        {
            get { return finishDate;}
            set { finishDate = value;}
        }

        public Airplane()
        {
            startCity = "Milan";
            finishCity = "Madrid";
            startDate = new Date();
            finishDate = new Date();
        }

        public Airplane(string startCity, string finishCity)
        {
            this.startCity = startCity;
            this.finishCity = finishCity;
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate) : this(startCity, finishCity)
        {
            this.startDate = new Date(startDate);
            this.finishDate = new Date(finishDate);
        }

        public Airplane(Airplane otherAirplane)
        {
            startCity = otherAirplane.startCity;
            finishCity = otherAirplane.finishCity;
            startDate = otherAirplane.startDate;
            finishDate = otherAirplane.finishDate;
        }

        public double GetTotalTime()
        {
            var start = new DateTime(StartDate.GetYear(), StartDate.GetMonth(), StartDate.GetDay(), StartDate.GetHours(), StartDate.GetMinutes(), 0);
            var finish = new DateTime(FinishDate.GetYear(), FinishDate.GetMonth(), FinishDate.GetDay(), FinishDate.GetHours(), FinishDate.GetMinutes(), 0);
            var difference = finish - start;
            return difference.TotalMinutes;
        }

        public bool IsArrivingToday()
        {
            return StartDate.GetYear() == FinishDate.GetYear() &&
                StartDate.GetMonth() == FinishDate.GetMonth() &&
                StartDate.GetDay() == FinishDate.GetDay();
        }

    }
}