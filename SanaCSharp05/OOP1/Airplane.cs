using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Airplane
    {
        public string StartCity { get; set; }
        public string FinishCity { get; set; }
        public Date StartDate { get; set; }
        public Date FinishDate { get; set; }
        public Airplane()
        {
            StartCity = "Empty";
            FinishCity = "Empty";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(string StartCity,Date StartDate)
        {
            this.StartCity = StartCity;
            this.StartDate = StartDate;
        }

        public Airplane(string StartCity,string FinishCity, Date StartDate,Date FinishDate)
        {
            this.StartCity = StartCity;
            this.FinishCity = FinishCity;
            this.StartDate = StartDate;
            this.FinishDate = FinishDate;
        }
        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = obj.StartDate;
            FinishDate = obj.FinishDate;
        }
        public int GetTotalTime()
        {
            int sumTime=0;
            if(FinishDate > StartDate)
            {
                sumTime+=(FinishDate.Year-StartDate.Year)* 525600;
                sumTime+=(FinishDate.Month-StartDate.Month)* 43200;
                sumTime+=(FinishDate.Day-StartDate.Day)* 1440;
                sumTime+=(FinishDate.Hours-StartDate.Hours)* 60;
                sumTime+=FinishDate.Minutes-StartDate.Minutes;
            }
            return sumTime;
        }
    }
}
