using System;

namespace OOP1
{
    public class Airplane
    {
        protected string startCity;
        public string StartCity
        {
            get { return startCity; }
            set { if (!String.IsNullOrEmpty(startCity)) startCity = value; }
        }
        protected string finishCity;
        public string FinishCity
        {
            get { return finishCity; }
            set { if (!String.IsNullOrEmpty(finishCity)) finishCity = value; }
        }
        protected Date startDate;
        public Date StartDate
        {
            get { return startDate; }
            set { if (!(value is null)) startDate = new Date(value); }
        }
        protected Date finishDate;
        public Date FinishDate
        {
            get { return finishDate; }
            set { if (!(value is null)) finishDate = new Date(value); }
        }

        public Airplane()
        {
            StartCity = "Kyiv";
            FinishCity = "Manchester";
            StartDate = new Date(2012, 10, 20, 15, 0);
            FinishDate = new Date(2012, 10, 20, 20, 15);
        }
        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate) : this(startCity, finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
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
            int totalTime = 0;
                if (IsArrivingToday())
                {
                    totalTime = (FinishDate.Hours - StartDate.Hours) * 60;
                    if (StartDate.Minutes <= FinishDate.Minutes)
                        totalTime += FinishDate.Minutes - StartDate.Minutes;
                    
                    else
                        totalTime -= StartDate.Minutes - FinishDate.Minutes;

                }
                else
                {
                    if (StartDate.Month == FinishDate.Month)
                        totalTime = (FinishDate.Day - StartDate.Day) * 24 * 60;
                    else
                    {
                        if (StartDate.Month == 4 || StartDate.Month == 6 ||
                            StartDate.Month == 9 || StartDate.Month == 11)
                                totalTime = (FinishDate.Day + 30 - StartDate.Day) * 60 * 24;

                        if (StartDate.Month == 1 || StartDate.Month == 3 ||
                            StartDate.Month == 5 || StartDate.Month == 7 ||
                            StartDate.Month == 8 || StartDate.Month == 10 ||
                            StartDate.Month == 12)
                                totalTime = (FinishDate.Day + 31 - StartDate.Day) * 60 * 24;

                        if (StartDate.Month == 2)
                        {
                            if (StartDate.Year % 4 == 0)
                                totalTime = (FinishDate.Day + 29 - StartDate.Day) * 60 * 24;
                            else
                                totalTime = (FinishDate.Day + 28 - StartDate.Day) * 60 * 24;
                        }

                    }
                    if (StartDate.Hours >= FinishDate.Hours)
                        totalTime -= (StartDate.Hours - FinishDate.Hours) * 60;
                    else
                        totalTime += (FinishDate.Hours - StartDate.Hours) * 60;
                    if (StartDate.Minutes <= FinishDate.Minutes)
                        totalTime += FinishDate.Minutes - StartDate.Minutes;
                    else
                        totalTime -= StartDate.Minutes - FinishDate.Minutes;
                }
     
            return totalTime;
        }

        public bool IsArrivingToday()
        {
            if (StartDate.Year == FinishDate.Year && StartDate.Month == FinishDate.Month
                && StartDate.Day == FinishDate.Day)
                return true;
            return false;
        }
    }
}
