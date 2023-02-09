using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;
        public Airplane()
        {
            StartCity = "Київ";
            FinishCity = "Житомир";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity=startCity;
            FinishCity=finishCity;
            StartDate = new(startDate);
            FinishDate = new (finishDate);
        }
        public Airplane(Date starDate, Date finishDate)
        {
            StartCity = "Житомир";
            FinishCity = "Київ";
            StartDate = starDate;
            FinishDate = finishDate;
        }
        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = new Date(obj.StartDate);
            FinishDate = new Date(obj.FinishDate);
        }
        public double GetTotalTime()
        {
            int totalTime = -((StartDate.GetYear() - FinishDate.GetYear()) * 365 * 24 * 60 + (StartDate.GetMonth() - FinishDate.GetMonth()) * 30 * 24 * 60 + (StartDate.GetDay() - FinishDate.GetDay()) * 24 * 60 + (StartDate.GetHours() - FinishDate.GetHours()) * 60 + (StartDate.GetMinutes() - FinishDate.GetMinutes()));
            return totalTime;
        }
        public override string ToString()
        {
            return $"Літак вилітає з {StartCity} о {StartDate} приземляється у {FinishCity} о {FinishDate}";
        }
        public bool IsArrivingToday()
        {
            if (StartDate.GetDay() == FinishDate.GetDay())
                return true;
            else 
                return false;
        }
        public void SetStartCity(string startCity) { StartCity = startCity; }
        public void SetFinishCity(string finishCity) { FinishCity = finishCity; }     
        public void SetStartDate(Date startDate) { StartDate = startDate; }
        public void SetFinishDate(Date finishDate) { FinishDate = finishDate; }

        public string GetStartCity() { return StartCity; }
        public string GetFinishCity() { return FinishCity; }    
        public Date GetStartDate() { return StartDate; }
        public Date GetFinishDate() { return FinishDate; }
    }

}
 