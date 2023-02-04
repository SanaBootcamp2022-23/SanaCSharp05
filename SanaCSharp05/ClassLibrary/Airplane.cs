using System;

namespace ClassLibrary
{
    public class Airplane
    {
        protected string startCity = "Unknown";
        protected string finishCity = "Unknown";
        public Date StartDate { get; set; } = new Date();
        public Date FinishDate { get; set; } = new Date();
        public string StartCity
        {
            get { return startCity; }
            set { if (value.Length > 0)  startCity = value; }
        }
        public string FinishCity
        {
            get { return finishCity; }
            set { if (value.Length > 0) finishCity = value; }
        }


        public Airplane()
        {

        }

        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate) 
            : this(startCity, finishCity)
        {
            StartDate = new Date(startDate);
            FinishDate = new Date(finishDate);
        }

        public Airplane(Airplane airplane) 
            : this(airplane.StartCity, airplane.FinishCity, airplane.StartDate, airplane.FinishDate) 
        {

        }

        public int GetTotalTime()
        {
            TimeSpan totalTime = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartDate.Hours, StartDate.Minutes, 0) 
                - new DateTime(FinishDate.Year, FinishDate.Month, FinishDate.Day, FinishDate.Hours, FinishDate.Minutes, 0);

            return (int)((totalTime.TotalMinutes < 0) ? (totalTime.TotalMinutes * - 1) : totalTime.TotalMinutes);
        }

        public bool IsArrivingToday()
        {
            return StartDate.Day == FinishDate.Day;
        }
    }
}