using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        string start_city = "";
        string finish_city = "";
        Date start_date;
        Date finish_date;
        public string StartCity
        {
            get { return start_city; }
            set { if(start_city != "") start_city = value; }
        }
        public string FinishCity
        {
            get { return finish_city; }
            set { if (finish_city != "") finish_city = value; }
        }
        public Date StartDate
        {
            get { return start_date; }
            set { start_date = value; }
        }
        public Date FinishDate
        {
            get { return finish_date; }
            set { finish_date = value; }
        }

        public Airplane() 
        {
            start_date = new Date();
            finish_date = new Date();
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            start_city = startCity;
            finish_city = finishCity;
            start_date = new Date(startDate);
            finish_date = new Date(finishDate);
        }
        public Airplane(string startCity, string finishCity) : this(startCity, finishCity, new Date(), new Date()) { }

        public Airplane(Airplane airplane) : this(airplane.start_city,airplane.finish_city,airplane.start_date,airplane.finish_date) { }

        public int GetTotalTime()
        {
            int final_total = finish_date.Year * 365 * 24 * 60 + finish_date.Month * 30 * 24 * 60 + finish_date.Day * 24 * 60 + finish_date.Hours * 60 + finish_date.Minutes;
            int start_total = start_date.Year * 365 * 24 * 60 + start_date.Month * 30 * 24 * 60 + start_date.Day * 24 * 60 + start_date.Hours * 60 + start_date.Minutes;
            return final_total - start_total;
        }
        public bool IsArrivingToday()
        {
            if (start_date.Day == finish_date.Day) 
                return true;
            else return false;
        }
    }
}