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
        public Airplane ()//конструктор по замовчуванню
        {
            StartCity = "Kyiv";
            FinishCity = "Mexico";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)//констуктор з параметром
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public Airplane(string startCity, string finishCity) //конструктор з параметром
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }
        public Airplane(Airplane obj)//конструктор копіювання 
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = new Date(obj.StartDate);
            FinishDate = new Date(obj.FinishDate);
        }

        //властивосі Get- та Set-
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
        public void SetFinishDate(Date finishDate)
        {
            FinishDate = finishDate;
        }
        public int GetTotalTime()//GetTotalTime(), який обраховує сумарний час подорожі у хвилинах
        {
            int totalTime = 0;
            totalTime += (FinishDate.GetYear() - StartDate.GetYear()) * 525600;
            totalTime += (FinishDate.GetMonth() - StartDate.GetMonth()) * 43800;
            totalTime += (FinishDate.GetDay() - StartDate.GetDay()) * 1440;
            totalTime += (FinishDate.GetHours() - StartDate.GetHours()) * 60;
            totalTime += FinishDate.GetMinutes() - StartDate.GetMinutes();
            return totalTime;
        }
        public bool IsArrivingToday()//IsArrivingToday(), що повертає true, якщо відправлення і прибуття в той же день
        {
            if (StartDate.GetYear() == FinishDate.GetYear()
                && StartDate.GetMonth() == FinishDate.GetMonth()
                && StartDate.GetDay() == FinishDate.GetDay())
            {
                return true;
            }
            else return false;
        }
    }
}
