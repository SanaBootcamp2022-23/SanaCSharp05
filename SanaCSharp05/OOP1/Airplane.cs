using OOP1;
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

        public Airplane() { }

        public Airplane(string startCity, string endCity, Date startDate, Date finishDate)
        {
            this.StartCity = startCity;
            this.FinishCity = endCity;
            this.StartDate = startDate;
            this.FinishDate = finishDate;
        }
        public Airplane(Date startDate, Date finishDate)
        {
            this.StartDate = startDate;
            this.FinishDate = finishDate;
        }
        public Airplane(string startCity, string finishCity)
        {
            this.StartCity = startCity;
            this.FinishCity = finishCity;
        }
        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = obj.StartDate;
            FinishDate = obj.FinishDate;
        }


        public string Startcity
        {
            get
            {
                return StartCity;
            }
            set
            {
                value = StartCity;
            }
        }
        public string Finishcity
        {
            get
            {
                return FinishCity;
            }
            set
            {
                value = FinishCity;
            }
        }
        public int GetTotalTime()
        {
            return (int)
                (new DateTime(this.FinishDate.YEar, this.FinishDate.MOnth, this.FinishDate.DAy, this.FinishDate.HOurs, this.FinishDate.MInutes, 0))
                            .Subtract
                (new DateTime(this.StartDate.YEar, this.StartDate.MOnth, this.StartDate.DAy, this.StartDate.HOurs, this.StartDate.MInutes, 0)).TotalMinutes;
        }
        public bool IsArrivingToday()
        {
            return
            (new Date
            (this.StartDate.YEar, this.StartDate.MOnth, this.StartDate.DAy))
            .Equals
            (new Date
            (this.FinishDate.YEar, this.FinishDate.MOnth, this.FinishDate.DAy));
        }
    }
}