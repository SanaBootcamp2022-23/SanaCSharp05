using System;
using System.Collections.Generic;
using System.Globalization;
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
            get { return startCity; }
            set { if (!string.IsNullOrEmpty(value)) startCity = value; }
        }
        public string FinishCity
        {
            get { return finishCity; }
            set { if (!string.IsNullOrEmpty(value)) finishCity = value; }
        }
        public Date StartDate
        {
            get { return startDate; }
            set { if (value != null) startDate = new Date(value); }
        }
        public Date FinishDate
        {
            get { return finishDate; }
            set { if (value != null) finishDate = new Date(value); }
        }
        public Airplane() { }
        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = new Date(airplane.StartDate);
            FinishDate = new Date(airplane.FinishDate);
        }
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
        private bool areDatesSetted()
        {
            return StartDate != null && FinishDate != null;
        }
        public int? GetTotalTime()
        {
            if (areDatesSetted())
            {
                int totalTravelMinutesTime, yearDiff = 0, monthDiff = 0, dayDiff = 0, hoursDiff = 0, minutesDiff = 0;
                if (StartDate.Year < FinishDate.Year) yearDiff = (FinishDate.Year - StartDate.Year) * Date.MINUTES_IN_YEAR;
                if (StartDate.Month < FinishDate.Month) monthDiff = (FinishDate.Month - StartDate.Month) * Date.MINUTES_IN_MONTH;
                if (StartDate.Day < FinishDate.Day) dayDiff = (FinishDate.Day - StartDate.Day) * Date.MINUTES_IN_DAY;
                if (StartDate.Hours < FinishDate.Hours) hoursDiff = (FinishDate.Hours - StartDate.Hours) * Date.MINUTES_IN_HOUR;
                if (StartDate.Minutes < FinishDate.Minutes) minutesDiff = FinishDate.Minutes - StartDate.Minutes;
                totalTravelMinutesTime = yearDiff + monthDiff + dayDiff + hoursDiff + minutesDiff;
                return totalTravelMinutesTime;
            }
            return null;
        }
        public bool? IsArrivingToday()
        {
            if (areDatesSetted())
                return StartDate.Equals(FinishDate);
            return null;
        }









    }
}
