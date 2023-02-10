using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        private string StartCity = "Unknown";
        private string FinishCity = "Unknown";
        private Date StartDate;
        private Date FinishDate;
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new Date(startDate);
            FinishDate = new Date(finishDate);
        }
        public Airplane() {}
        public Airplane (Date startDate, Date finishDate)
        {
            StartDate = new Date(startDate);
            FinishDate = new Date(finishDate);
        }
        
        public Airplane(Airplane airplane)
        {
            StartCity=airplane.StartCity;
            FinishCity=airplane.FinishCity;
            StartDate=airplane.StartDate;
            FinishDate=airplane.FinishDate;
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


        public bool SetStartCity(string startCity)
        {
            if (startCity.Length > 0) 
            { 
                StartCity=startCity;
                return true; 
            }
            else { return false; }
        }
        public bool SetFinishCity(string finishCity)
        {
            if (finishCity.Length > 0) 
            {
                FinishCity = finishCity;
                return true; 
            }
            else { return false; }
        }
        public void SetStartDate(Date startDate) 
        {
            if(startDate.GetYear()>0 && startDate.GetYear() <= 2023 && startDate.GetDay()>0 && startDate.GetDay() <= 31 && startDate.GetHour() >=0 && startDate.GetHour() <= 24 && startDate.GetMonth()>0 && startDate.GetMonth()<=12 && startDate.GetMinute()<60 && startDate.GetMinute() > 0)
            {
                StartDate.SetYear(startDate.GetYear());
                StartDate.SetMonth(startDate.GetMonth());
                StartDate.SetDay(startDate.GetDay());
                StartDate.SetHour(startDate.GetHour());
                StartDate.SetMinute(startDate.GetMinute());
            }
        }
        public void SetFinishDate(Date finishDate)
        {
            if (finishDate.GetYear() > 0 && finishDate.GetYear() <= 2023 && finishDate.GetDay() > 0 && finishDate.GetDay() <= 31 && finishDate.GetHour() >= 0 && finishDate.GetHour() <= 24 && finishDate.GetMonth() > 0 && finishDate.GetMonth() <= 12 && finishDate.GetMinute() < 60 && finishDate.GetMinute() > 0)
            {
                FinishDate.SetYear(finishDate.GetYear());
                FinishDate.SetMonth(finishDate.GetMonth());
                FinishDate.SetDay(finishDate.GetDay());
                FinishDate.SetHour(finishDate.GetHour());
                FinishDate.SetMinute(finishDate.GetMinute());
            }
        }
        
        
        public int GetTotalTime()
        {
            int res = 0;
            int start = StartDate.GetYear()*365*24*60+StartDate.GetMonth()*30*24*60+StartDate.GetDay()*24*60+StartDate.GetHour()* 60 + StartDate.GetMinute();
            int finish = FinishDate.GetYear() * 365 * 24 * 60 + FinishDate.GetMonth() * 30 * 24 * 60 + FinishDate.GetDay() * 24 * 60 + FinishDate.GetHour() * 60+ FinishDate.GetMinute();
            
            res = finish-start;
            return res;
        }
        public bool IsArrivingToday()
        {
            if (StartDate.GetYear() == FinishDate.GetYear() && StartDate.GetMonth() == FinishDate.GetMonth() && StartDate.GetDay() == FinishDate.GetDay()) 
            {
                return true; 
            }
            else { return false; }
        }
    }
}
