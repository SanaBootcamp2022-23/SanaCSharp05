using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        protected string Start_City = "";
        protected string Finish_City = "";
        protected Date Start_Date;
        protected Date Finish_Date;
        public string StartCity
        {
            get { return Start_City; }
            set { if (!string.IsNullOrEmpty(value)) Start_City = value; }
        }
        public string FinishCity
        {
            get { return Finish_City; }
            set { if (!string.IsNullOrEmpty(value)) Finish_City = value; }
        }
        public Date StartDate
        {
            get { return Start_Date; }
            set { Start_Date = value; }
        }
        public Date FinishDate
        {
            get { return Finish_Date; }
            set { Finish_Date = value; }
        }
        public Airplane() {
            Start_Date = Date.Default;
            Finish_Date = Date.Default;
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            Start_City = startCity;
            Finish_City = finishCity;
            Start_Date = startDate;
            Finish_Date = finishDate;
        }
        public Airplane(Date startDate, Date finishDate)
        {
            Start_Date = startDate;
            Finish_Date = finishDate;
        }
        public Airplane(Airplane PreviousAirplane)
        {
            Start_City = PreviousAirplane.Start_City;
            Finish_City = PreviousAirplane.Finish_City;
            Start_Date = PreviousAirplane.Start_Date;
            Finish_Date = PreviousAirplane.Finish_Date;
        }
        public Airplane Copy()
        {
            return new(this);
        }
        public int GetTotalTime()
        {
            int TotalTime = Finish_Date.Minute - Start_Date.Minute + (Finish_Date.Hour - Start_Date.Hour) * 60 +
                (Finish_Date.Day - Start_Date.Day) * 60 * 24 +
                (Finish_Date.Month - Start_Date.Month) * 60 * 24 * 30 +
                (Finish_Date.Year - Start_Date.Year) * 60 * 24 * 30 * 12;
            return (TotalTime);
        }
        public bool IsArrivingToday()
        {
            return Finish_Date.Year == Start_Date.Year &&
                Finish_Date.Month == Start_Date.Month && Finish_Date.Day == Start_Date.Day;
        }
        public void Show()
        {
            Console.WriteLine("Start city:        " + Start_City);
            Console.WriteLine("Finish city:       " + Finish_City);
            Console.WriteLine("Start date:        " + $"{Start_Date.Year}.{Start_Date.Month}.{Start_Date.Day} {Start_Date.Hour}:{Start_Date.Minute}");
            Console.WriteLine("Finish date:       " + $"{Finish_Date.Year}.{Finish_Date.Month}.{Finish_Date.Day} {Finish_Date.Hour}:{Finish_Date.Minute}");
            Console.WriteLine("Total time:        " + GetTotalTime());
            Console.WriteLine("Is arriving today: " + IsArrivingToday());
        }
    }
}
