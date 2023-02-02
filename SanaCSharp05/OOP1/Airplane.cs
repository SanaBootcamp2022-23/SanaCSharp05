using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        private string startcity;
        public string StartCity
        {
            set { startcity = value; }
            get { return startcity; }
        }

        private string finishcity;
        public string FinishCity
        {
            set { finishcity = value; }
            get { return finishcity; }
        }

        private Date startdate;
        public Date StartDate
        {
            set { startdate = value; }
            get { return startdate; }
        }

        private Date finishdate;
        public Date FinishDate
        {
            set { finishdate = value; }
            get { return finishdate; }
        }
        public Airplane(string Startcity,string Finishcity)
        {
            startcity = Startcity;
            finishcity = Finishcity;
            startdate = null;
            finishdate = null;
        }
        public Airplane(string Startcity, string Finishcity,Date start,Date finish)
        {
            startcity = Startcity;
            finishcity = Finishcity;
            startdate = new Date(start);
            finishdate = new Date(finish);
        }
        public Airplane()
        {
          
        }

        public Airplane(Airplane plane)
        {
            startcity = plane.startcity;
            finishcity = plane.finishcity;
            startdate = plane.startdate;
            finishdate = plane.finishdate;
        }

        public bool IsArrivingToday()
        {
            if (startdate.Day == finishdate.Day && startdate.Month==finishdate.Month && startdate.Year==finishdate.Year)
                return true;
            return false;
        }

        public void GetTotalTime()
        {
            DateTime date1 = new DateTime(startdate.Year, startdate.Month, startdate.Day, startdate.Hours, startdate.Minutes, 0);
            DateTime date2 = new DateTime(finishdate.Year, finishdate.Month, finishdate.Day, finishdate.Hours, finishdate.Minutes, 0);
            Console.WriteLine(date1.ToString("g") + " - " + date2.ToString("g"));
            TimeSpan resultTotal = date2.Subtract(date1);
            int resulMinutes = (int)resultTotal.TotalMinutes;
            Console.WriteLine("Total time: " + resultTotal + "; In minutes: " + resulMinutes +"m");
        }
    }
}
