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

        public Airplane ()
        {
            StartCity = "Zhytomyr";
            FinishCity = "Prague";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane (string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(Date startDate, Date finishDate)
        {
            StartCity = "Zhytomyr";
            FinishCity = "Prague";
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public Airplane (Airplane plane)
        {
            StartCity = plane.StartCity;
            FinishCity = plane.FinishCity;
            StartDate = new Date(plane.StartDate);
            FinishDate = new Date(plane.FinishDate);
        }
        public string GetStartCity ()
        {
            return StartCity;
        }
        public void SetStartCity(string startCity)
        {
            if (!String.IsNullOrEmpty(startCity))
            {
                StartCity = startCity;
            }
        }
        public string GetFinishCity()
        {
            return FinishCity;
        }
        public void SetFinishCity(string finishCity)
        {
            if (!String.IsNullOrEmpty(finishCity))
            {
                FinishCity = finishCity;
            }
        }
        public Date GetStartDate()
        {
            return StartDate;
        }
        public void SetStartDate(Date startDate)
        {
            StartDate = new(startDate);
        }
        public Date GetFinishDate()
        {
            return FinishDate;
        }
        public void SetFinishDate(Date finishDate)
        {
            FinishDate = new(finishDate);
        }
        public int GetTotalTime()
        {
            int TotalTime = 0,
                Dfr_Year = 0,
                Dfr_Month = 0,
                Dfr_Days = 0,
                Dfr_Hours = 0,
                Dfr_Minutes = 0;
            if (StartDate.GetYear() < FinishDate.GetYear())
                Dfr_Year = FinishDate.GetYear() - StartDate.GetYear();
            if (StartDate.GetMonth() < FinishDate.GetMonth())
                Dfr_Month = FinishDate.GetMonth() - StartDate.GetMonth();
            if (StartDate.GetDay() < FinishDate.GetDay())
                Dfr_Days = FinishDate.GetDay() - StartDate.GetDay();
            if (StartDate.GetHours() < FinishDate.GetHours())
                Dfr_Hours = FinishDate.GetHours() - StartDate.GetHours();
            if (StartDate.GetMinutes() < FinishDate.GetMinutes())
                Dfr_Minutes = FinishDate.GetMinutes() - StartDate.GetMinutes();
            TotalTime = (Dfr_Year * 365 * 30 * 24 * 60) + (Dfr_Month * 30 * 24 * 60) + (Dfr_Days * 24 * 60) + (Dfr_Hours * 60) + Dfr_Minutes;
            return TotalTime;
        }
        public bool IsArrivingToday (Airplane pln)
        {
            bool YesOrNot = false;
            if (pln.StartDate != null && pln.FinishDate != null)
                if (pln.StartDate.GetYear == pln.FinishDate.GetYear && pln.StartDate.GetMonth == pln.FinishDate.GetMonth && pln.StartDate.GetDay == pln.FinishDate.GetDay)
                    YesOrNot = true;
            return YesOrNot;
        }
    }
}
