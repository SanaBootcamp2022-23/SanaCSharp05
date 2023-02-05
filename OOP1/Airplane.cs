using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        protected string StartCity;
        public string startCity
        {
            set
            {
                if (value != "") 
                {
                    StartCity= value;
                }

            }
            get
            {
                return StartCity;
            }
        }

        protected string FinishCity;
        public string finishCity
        {
            set
            {
                if (value != "")
                {
                    FinishCity = value;
                }

            }
            get
            {
                return FinishCity;
            }
        }

        protected Date StartDate;
        public Date startDate
        {
            set 
            {
                StartDate = new Date(value);
            }
            get { return StartDate; }
        }
        protected Date FinishDate;
        public Date finishDate
        {
            set
            {
                FinishDate = new Date(value);
            }
            get { return FinishDate; }
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new Date (startDate);
            FinishDate = new Date (finishDate);
        }

        public Airplane(string startCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            StartDate = startDate;
            FinishDate = new Date (finishDate);

        }

        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }

        public Airplane()
        {

        }

        public Airplane(Airplane plane)
        {
            StartCity = plane.StartCity;
            FinishCity = plane.FinishCity;
            StartDate = new Date(plane.StartDate);
            FinishDate = new Date(plane.FinishDate);
        }


        public int GetTotalTime(Date startDate, Date finishDate)
        {
            int time = 0;

            if(startDate.Year == finishDate.Year)
            {
                time = finishDate.totalMin() - startDate.totalMin() ;
            }
            else
            {
                time = (365 + startDate.highYear()) * 24 * 60 - startDate.Minute + finishDate.Minute;
            }
            return time;
        }

        public bool IsArrivingToday(Date startDate, Date finishDate)
        {
            bool isArrivingToday = false;
            if (startDate.Year == finishDate.Year && startDate.Month == finishDate.Month && startDate.Day == finishDate.Day)
            {
                isArrivingToday = true;
            }

            return isArrivingToday;
        }
    }
}
