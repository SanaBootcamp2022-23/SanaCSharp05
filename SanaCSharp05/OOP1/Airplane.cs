using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        private string startCity;
        private string finishCity;
        private Date startDate;
        private Date finishDate;

        public string StartCity
        {
            get { return StartCity; }
            set { if(!String.IsNullOrEmpty(value)) startCity = value; }
        }

        public string FinishCity
        {
            get { return FinishCity; }
            set { if (!String.IsNullOrEmpty(value)) startCity = value; }
        }

        public Date StartDate
        {
            get { return startDate; }
            set { if(value != null) startDate = new Date(value); }
        }

        public Date FinishDate
        {
            get { return finishDate; }
            set { if (value != null) finishDate = new Date(value); }
        }

        public Airplane() {}

        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate) : this(startCity, finishCity)
        {
            StartDate = new Date(startDate);
            FinishDate = new Date(finishDate);
        }

        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = new Date(airplane.StartDate);
            FinishDate = new Date(airplane.FinishDate);
        }

        public int GetTotalTime()
        {
                int totalTravelTimeInMinutes, timeYearDifference = 0, timeMonthDifference = 0, 
                    timeDayDifference = 0, timeHourDifference = 0, timeMinuteDifference = 0;
                if (StartDate.Year < FinishDate.Year)       { timeYearDifference = (FinishDate.Year - StartDate.Year) * 525600; }
                if (StartDate.Month < FinishDate.Month)     { timeMonthDifference = (FinishDate.Month - StartDate.Month) * 44640; }
                if (StartDate.Day < FinishDate.Day)         { timeDayDifference = (FinishDate.Day - StartDate.Day) * 1440; }
                if (StartDate.Hours < FinishDate.Hours)     { timeHourDifference = (FinishDate.Hours - StartDate.Hours) * 60; }
                if (StartDate.Minutes < FinishDate.Minutes) { timeMinuteDifference = FinishDate.Minutes - StartDate.Minutes; }
                totalTravelTimeInMinutes = timeYearDifference + timeMonthDifference + timeDayDifference +
                timeHourDifference + timeMinuteDifference;
            
            return totalTravelTimeInMinutes;
        }

        public bool IsArrivingToday()
        {
            if (StartDate != null && FinishDate != null)
            {
                if (StartDate.Year == FinishDate.Year && StartDate.Month == FinishDate.Month && StartDate.Day == FinishDate.Day)
                    return true;
            }
            return false;
        }
    }
}
