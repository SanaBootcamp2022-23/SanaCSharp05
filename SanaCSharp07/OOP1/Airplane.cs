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
        protected string startCity = "Tokyo";
        public string StartCity
        {
            get { return startCity; }
            set { 
                if (value != "")
                    startCity = value;
                else
                {
                    throw new Exception("Error");
                }
                    
                    
                        }
}
        protected string finishCity = "Kyiv";
        
        public String FinishCity
        {
            get { return finishCity; }
            set
            {
                if (value != "")
                    finishCity = value;
                else
                {
                    throw new Exception("Error");
                }
            }
        }
        protected Date startDate;
        public Date StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        protected Date finishDate;
        public Date FinishDate
        {
            get { return finishDate; }
            set
            {
                if (value.Year >= startDate.Year)
                    finishDate = value;
            }
        }

        public Airplane()
        {
            StartCity = "Tokyo";
            FinishCity = "Kyiv";
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
        public Airplane(string startCity, string finishCity, Date startDate) : this (startCity, finishCity)
        {
            StartDate = startDate;
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate) : this(startCity, finishCity, startDate)
        {
            FinishDate = finishDate;
        }
        public Airplane(Airplane obj)
        {
            startCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = obj.StartDate;
            FinishDate = obj.FinishDate;
        }
        public double GetTotalTime()
        {
            double result = (FinishDate.Year - StartDate.Year) * 365 * 24 * 60;
            result += (FinishDate.Months - StartDate.Months) * 365 / 12 * 24 * 60;
            result += (FinishDate.Days - StartDate.Days) * 24 * 60;
            result += (FinishDate.Hours - StartDate.Hours) * 60;
            result += FinishDate.Minutes - StartDate.Minutes;
            return result;
        }
        public bool IsArrivingToday (Date StartDate, Date FinishDate)
        {
            if (startDate.Year == finishDate.Year && startDate.Days == finishDate.Days && startDate.Months == finishDate.Months)
                return true;
            else return false;
        }
    }
}
