using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Airplane
    {
        private string StartCity;
        private string FinishCity;
        private Date StartDate;
        private Date FinishDate;
        public Airplane()
        {
            StartCity = "Unknown";
            FinishCity = "Unknown";
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
        }

        public Airplane(Airplane obj)
        {
            this.StartCity = obj.StartCity;
            this.FinishCity = obj.FinishCity;
            this.StartDate = obj.StartDate;
            this.FinishDate = obj.FinishDate;
        }

        public string startCity
        {
            private set { if (value.Length > 0) StartCity = value; }
            get { return StartCity; }
        }
        public string finishCity
        {
            private set { if (value.Length > 0) FinishCity = value; }
            get { return FinishCity; }
        }
        
        public Date startDate
        {
            set { StartDate = value; }
            get { return StartDate; }
        }
        public Date finishDate
        {
            set { FinishDate = value; }
            get { return FinishDate; }
        }

        public int GetStartDateYear
        {
            get { return StartDate.year; }
        }
        public int GetStartDateMonth
        {
            get { return FinishDate.month; }
        }
        public int GetStartDateDay
        {
            get { return StartDate.day; }
        }

        public int GetFinishDateYear
        {
            get { return FinishDate.year; }
        }
        public int GetFinishDateMonth
        {
            get { return FinishDate.month; }
        }
        public int GetFinishDateDay
        {
            get { return FinishDate.day; }
        }

        public bool IsArrivingToday()
        {
            if (StartDate.day == FinishDate.day && StartDate.month == FinishDate.month && StartDate.year == FinishDate.year) return true;
            else return false;
        }

        public int GetTotalTime()
        {
            return (FinishDate.minute - StartDate.minute) + ((FinishDate.hour-StartDate.hour)*60)+(FinishDate.day- StartDate.day)*24*60;
        }
    }  
}
