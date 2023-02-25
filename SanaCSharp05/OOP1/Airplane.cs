using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP1
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public string GetStartCity()
        {
            return StartCity;
        }
        public string GetFinishCity()
        {
            return FinishCity;
        }
        public Date GetStartDate()
        {
            return StartDate;
        }
        public Date GetFinishDate()
        {
            return FinishDate;
        }
        public void SetStartCity(string startCity)
        {
            StartCity = startCity;
        }
        public void SetFinishCity(string finishCity)
        {
            FinishCity = finishCity;
        }
        public void SetStartDate(Date startDate)
        {
            StartDate = startDate;
        }

        public double GetotalTime()
        {
            double result = (FinishDate.Year - StartDate.Year) * 365 * 24 * 60;
            result += (FinishDate.Month - StartDate.Month) * 365 / 12 * 24 * 60;
            result += (FinishDate.Day - StartDate.Day) * 24 * 60;
            result += (FinishDate.Hours - StartDate.Hours) * 60;
            result += FinishDate.Minutes - StartDate.Minutes;
            return result;
        }

        public bool IsArrivingToday(Date startDate, Date finishDate)
        {
            if (startDate == finishDate)
            {
                return true;
            }
            return false;
        }
    }
}
