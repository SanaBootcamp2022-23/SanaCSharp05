using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Airplane
    {
        protected string StartCity = "Unknown";
        protected string FinishCity = "Unknown";
        protected Date StartDate;
        protected Date FinishDate;
        public Airplane()
        {
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate) 
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new Date(startDate);
            FinishDate = new Date(finishDate);
        }
        public Airplane(string finishCity, Date startDate, Date finishDate)
        {
            FinishCity = finishCity;
            StartDate = new Date(startDate);
            FinishDate = new Date(finishDate);
        }
        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = new Date(obj.StartDate);
            FinishDate = new Date(obj.FinishDate);
        }
        public void PrintInfo()
        {
            Console.WriteLine($"\nStart city: {StartCity}");
            Console.WriteLine($"Finish city: {FinishCity}");
            StartDate.GetFullDate();
            FinishDate.GetFullDate();
        }
        public string GetStartCity()
        {
            return StartCity;
        }
        public string GetFinishCity()
        {
            return FinishCity;
        }
        public void GetStartDate()
        {
            StartDate.GetFullDate();
        }
        public void GetFinishDate()
        {
            FinishDate.GetFullDate();
        }
        public void SetStartCity(string city)
        {
            StartCity = city;
        }
        public void SetFinishCity(string city)
        {
            FinishCity = city;
        }
        public void SetStartDate(int year, int month, int day, int hours, int minutes)
        {
            StartDate = new Date(year, month, day, hours, minutes);
        }
        public void SetFinishDate(int year, int month, int day, int hours, int minutes)
        {
            FinishDate = new Date(year, month, day, hours, minutes);
        }
        public int GetTotalTime(Date startDate, Date finishDate)
        {
            int result = 0;
            int startYear = startDate.GetYear();
            int finishYear = finishDate.GetYear();
            int startMonth = startDate.GetMonth();
            int finishMonth = finishDate.GetMonth();
            int startDay = startDate.GetDay();
            int finishDay = finishDate.GetDay();
            int startHour = startDate.GetHour();
            int finishHour = finishDate.GetHour();
            int startMinute = startDate.GetMinute();
            int finishMinute = finishDate.GetMinute();
            if (finishYear >= startYear && finishMonth >= startMonth)
            {
                if (finishDay >= startDay)
                {
                    result = (finishDay - startDay) * 1440 + (finishHour - startHour) * 60 + (finishMinute - startMinute);
                }
                else
                {
                    result = (31 - startDay + finishDay) * 1440 + (finishHour - startHour) * 60 + (finishMinute - startMinute);
                }
            }
            if (result >= 0)
                return result;
            else
                throw new Exception("Incorrect finish date!");
        }
        public bool IsArrivingToday(Date startDate, Date finishDate)
        {
            int startYear = startDate.GetYear();
            int finishYear = finishDate.GetYear();
            int startMonth = startDate.GetMonth();
            int finishMonth = finishDate.GetMonth();
            int startDay = startDate.GetDay();
            int finishDay = finishDate.GetDay();
            if(startYear == finishYear && startMonth == finishMonth && startDay == finishDay)
                return true;
            else
                return false;
        }
    }
}
