using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane //оголошення класу
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;
        public Airplane() //конструктор по-замовчуванню
        {
            StartCity = "Zhytomyr";
            FinishCity = "London";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(string startCity, string finishCity) //конструктор з параметром(1)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }
        public Airplane(string finishCity) //конструктор з параметром(2)
        {
            FinishCity = finishCity;
        }
        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = new Date(obj.StartDate);
            FinishDate = new Date(obj.FinishDate);
        }
        // реалізація властивостей Get- та Set-
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
            if (!string.IsNullOrEmpty(startCity))
            {
                StartCity = startCity;
            }
        }
        public void SetFinishCity(string finishCity)
        {
            if (!string.IsNullOrEmpty(finishCity))
            {
                FinishCity = finishCity;
            }
        }
        public void SetStartDate(Date startDate)
        {
            StartDate = startDate;
        }
        public void SetFinishDate(Date finishDate)
        {
            FinishDate = finishDate;
        }

        public int GetTotalTime() // обрахування сумарний час подорожі у хвилинах
        {
            int HourFinishDate = GetFinishDate().GetHours();
            int HourStartDate = GetStartDate().GetHours();
            int MinutesStartDate = GetStartDate().GetMinutes();
            int MinutesFinishDate = GetFinishDate().GetMinutes();
            int DifferenceInDay = GetFinishDate().GetDay() - GetStartDate().GetDay();
            int DifferenceInMounth = GetFinishDate().GetMonth() - GetStartDate().GetMonth();
            int DifferenceInYear = GetFinishDate().GetYear() - GetStartDate().GetYear();
            int TotalTime = (DifferenceInYear * 525960) + (DifferenceInMounth * 43800) + (DifferenceInDay * 1440) + ((HourFinishDate - HourStartDate) * 60) + (MinutesFinishDate - MinutesStartDate);

            return TotalTime;
        }
        public bool IsArrivingToday(Airplane ArrivalDay) // повертає true, якщо відправлення і прибуття в той же день
        {
            if (ArrivalDay.GetStartDate().GetYear() == ArrivalDay.GetFinishDate().GetYear() && ArrivalDay.GetStartDate().GetMonth() == ArrivalDay.GetFinishDate().GetMonth() && ArrivalDay.GetStartDate().GetDay() == ArrivalDay.GetFinishDate().GetDay())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
