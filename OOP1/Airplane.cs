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
        public Airplane()
        {
            startCity = "The city of departure is not specified";
            finishCity = "The city of arrival is not specified";
            startDate = new Date();
            finishDate = new Date();
        }
        public Airplane(string StartCity, string FinishCity, Date StartDate, Date FinishDate)
        {
            startCity = StartCity;
            finishCity = FinishCity;
            startDate = StartDate;      
            finishDate = FinishDate;  
        }
        public Airplane(string StartCity, string FinishCity)
        {
            startCity = StartCity;
            finishCity = FinishCity;
            startDate = new Date();
            finishDate = new Date();
       }
        public Airplane(Date StartDate, Date FinishDate)
        {
            startDate = StartDate;      
            finishDate = FinishDate;    
            startCity = "New York";
            finishCity = "London";
        }
        public Airplane(Airplane obj) 
        {
            startCity = obj.startCity;
            finishCity = obj.finishCity;
            startDate = obj.startDate;     
            finishDate = obj.finishDate;   
        }
        public string StartCity
        {
            set
            {
                if (value != "")
                    startCity = value;
            }
            get
            {
                return startCity;
            }
        }
        public string FinishCity
        {
            set
            {
                if (value != "")
                    finishCity = value;
            }
            get
            {
                return finishCity;
            }
        }
        public Date StartDate
        {
            set
            {
                startDate = value;
            }
            get
            {
                return startDate;
            }
        }
        public Date FinishDate
        {
            set
            {
                finishDate = value;
            }
            get
            {
                return finishDate;
            }
        }
        public int GetTotalTime()
        {
            DateTime start = new DateTime((int)startDate.Year, (int)startDate.Month, (int)startDate.Day,
                                          (int)startDate.Hours, (int)startDate.Minutes, 0);
            DateTime finish = new DateTime((int)finishDate.Year, (int)finishDate.Month, (int)finishDate.Day,
                                           (int)finishDate.Hours, (int)finishDate.Minutes, 0);
            TimeSpan duration = finish.Subtract(start);
            int totalTime = Convert.ToInt32(duration.TotalMinutes);
            return totalTime;
        }
        public bool IsArrivingToday()
        { 
            if (startDate.Year == finishDate.Year && startDate.Month == finishDate.Month && startDate.Day == finishDate.Day)
                return true;
            return false;

        }
    }
}
