using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        protected string startcity;
        public string StartCity
        {
            set { startcity = value; }
            get { return startcity; }
        }

        protected string finishcity;
        public string FinishCity
        {
            get { return finishcity; }
            set { finishcity = value; }
        }
        public Airplane(string startcity, string finishcity)
        {
            this.startcity = startcity;
            this.finishcity = finishcity;
        }
        public string GetRoute()
        {
            return $"{startcity} - {finishcity}";
        }
        protected Date startdate;
        public Date StartDate
        {

            get { return startdate; }
            set { startdate = value; }

        }
        protected Date finishdate;
        public Date FinishDate
        {
            get { return finishdate; }
            set
            {
                finishdate = value;
            }

        }

        public Date DateToMinutes { get; set; }

        public Airplane(double startdate, double finishdate, int year,int month,double hours,int minutes)
        {
            startdate = DateToMinutes;
            finishdate = DateToMinutes;
        }
       

        public Airplane(string startcity, string finishcity, Date startdate, Date finishdate)
        {
            this.startdate = startdate;
            this.finishdate = finishdate;
            this.startcity = startcity;
            this.finishcity = finishcity;
        }

        public double GetTotalTime(double finishdate, double startdate)
        {
            return finishdate ;
        }
        public bool IsArrivingTosday(Date startdate, Date finishdate)
        {
            if (startdate.Day == finishdate.Day)
                return true;
            else
                return false;
        }
        public Airplane(Airplane obj)
        {
            startcity = obj.startcity;
            finishcity = obj.finishcity;
            startdate = obj.startdate;
            finishdate = obj.finishdate;

        }
        

        }
        
    }