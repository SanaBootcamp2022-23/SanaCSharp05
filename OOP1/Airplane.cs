using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Airplane
    {
        protected string StartCity; // місто відправлення
        protected string FinishCity; // місто прибуття
        protected Date StartDate; // дата відправлення
        protected Date FinishDate; // дата прибуття
        public Airplane()
        {
            StartCity = "Житомир";
            FinishCity = "Париж";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity= startCity;   
            FinishCity= finishCity;
            StartDate = new(startDate);
            FinishDate = new(finishDate);
        }
        public Airplane(string finishCity, Date startDate, Date finishDate)
        {
            StartCity = "Харків";
            FinishCity = finishCity;
            StartDate = new(startDate);
            FinishDate = new(finishDate);
        }
        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = new Date(obj.StartDate);
            FinishDate = new Date(obj.FinishDate);

        }

        // Getters / Setters down
        public void SetStartCity(string startCity)
        {
            StartCity = startCity;
        }
        public string GetStartCity()
        {
            return StartCity;
        }
        public void SetFinishCity(string finishCity)
        {
            FinishCity = finishCity;
        }
        public string GetFinishCity()
        {
            return FinishCity;
        }
        public void SetStartDate(Date startDate)
        {
            StartDate = new(startDate);
        }
        public Date GetStartDate()
        {
            return StartDate;
        }
        public void SetFinishDate(Date finishDate)
        {
           FinishDate = new(finishDate);
        }
        public Date GetFinishDate()
        {
            return FinishDate;
        }
        public double GetTotalTime()
        {
            int totalTime = -((StartDate.GetYear() - FinishDate.GetYear()) * 365 * 24 * 60 + (StartDate.GetMonth() - FinishDate.GetMonth()) * 30 * 24 * 60 + (StartDate.GetDay() - FinishDate.GetDay()) * 24 * 60 + (StartDate.GetHour() - FinishDate.GetHour()) * 60 + (StartDate.GetMinute() - FinishDate.GetMinute()));
            return totalTime;
        }
        public bool IsArrivingToday()
        {
           if (StartDate.GetDay() == FinishDate.GetDay()) return true;
           else return false;
        }
        public override string ToString()
        {
           return $"Start date  : {StartDate.ToString()}\n" +
                                     $"Start city  : {StartCity}\n" +
                                     $"Finish date : {FinishDate.ToString()}\n" +
                                     $"Finish city : {FinishCity}\n" +
                                     $"Total time in minutes : {GetTotalTime()}\n" +
                                     $"Is arriving today : {IsArrivingToday()}";
        }
    }
}
