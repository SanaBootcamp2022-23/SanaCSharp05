using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        public Airplane()
        {
            this.StartCity = "Житомир";
            this.FinishCity = "Берлін";
            this.StartDate = new Date();
            this.FinishDate = new Date(this.StartDate.GetYear(), this.StartDate.GetMonth(), this.StartDate.GetDay()+1);
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate):this(startCity,finishCity)
        {
            this.StartDate = startDate;
            this.FinishDate = finishDate;
        }

        public Airplane(string startCity, string finishCity) 
        {
            this.StartCity = startCity;
            this.FinishCity = finishCity;
            this.StartDate = new Date();
            this.FinishDate = new Date(this.StartDate.GetYear(), this.StartDate.GetMonth(), this.StartDate.GetDay()+1);
        }

        public Airplane(Airplane obj)
        {
            this.StartCity = obj.StartCity;
            this.FinishCity = obj.FinishCity;
            this.StartDate = new Date(obj.StartDate);
            this.FinishDate = new Date(obj.FinishDate);
        }

        public void SetStartCity(string city)
        {
            if (city != "" && city.Length >= 2)
            {
                this.StartCity = city;
            }
        }

        public void SetFinishCity(string city)
        {
            if (city != "" && city.Length >= 2)
            {
                this.FinishCity = city;
            }
        }

        public void SetStartDate(Date date)
        {
            DateTime dateTimeStart = new DateTime(date.GetYear(), date.GetMonth(), date.GetDay(),date.GetHours(), date.GetMinutes(),0);
            DateTime dateTimeEnd = new DateTime(this.FinishDate.GetYear(), this.FinishDate.GetMonth(), this.FinishDate.GetDay(), this.FinishDate.GetHours(), this.FinishDate.GetMinutes(), 0);

            if(dateTimeStart<dateTimeEnd)
                this.StartDate = date;
        }

        public void SetFinishDate(Date date)
        {
            DateTime dateTimeEnd = new DateTime(date.GetYear(), date.GetMonth(), date.GetDay(), date.GetHours(), date.GetMinutes(), 0);
            DateTime dateTimeStart = new DateTime(this.StartDate.GetYear(), this.StartDate.GetMonth(), this.StartDate.GetDay(), this.StartDate.GetHours(), this.StartDate.GetMinutes(), 0);
           
            if (dateTimeStart < dateTimeEnd)
                this.FinishDate = date;
        }

        public string GetStartCity()
        {
            return this.StartCity;
        }

        public string GetFinishCity()
        {
            return this.FinishCity;
        }

        public Date GetStartDate()
        {
            return this.StartDate;
        }

        public Date GetFinishDate()
        {
            return this.FinishDate;
        }


        public int GetTotalTime()
        {
            DateTime dateTimeStart = new DateTime(StartDate.GetYear(), StartDate.GetMonth(), StartDate.GetDay(), StartDate.GetHours(), StartDate.GetMinutes(), 0);
            DateTime dateTimeFinish = new DateTime(FinishDate.GetYear(), FinishDate.GetMonth(), FinishDate.GetDay(), FinishDate.GetHours(), FinishDate.GetMinutes(), 0);
            TimeSpan totalTime = dateTimeFinish - dateTimeStart;
            return totalTime.Days*24*60+totalTime.Hours*24+totalTime.Minutes;
        }

        public bool IsArrivingToday()
        {
            if(StartDate.GetYear()==FinishDate.GetYear()&& StartDate.GetMonth() == FinishDate.GetMonth() && StartDate.GetDay() == FinishDate.GetDay())
            {
                return true;
            }
            return false;
        }
    }
}
