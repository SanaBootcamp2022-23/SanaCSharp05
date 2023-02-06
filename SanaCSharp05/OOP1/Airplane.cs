using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        private string _startCity;
        private string _finishCity;
        private Date _startDate;
        private Date _finishDate;

        public void PrintAir()
        {
            Console.WriteLine("Start City: " + StartCity);
            Console.WriteLine("Finish City: " + FinishCity);
            Console.WriteLine("Date" );
            StartDate.PrintDate();
            Console.WriteLine("Date");
            FinishDate.PrintDate();

           
        }
        public Airplane()
        {
            StartCity = "";
            FinishCity = "";
            StartDate = new Date();
            FinishDate = new Date();
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;

        }
        public Airplane(Airplane CopyAirplane)
        {
            StartCity = CopyAirplane.StartCity;
            FinishCity = CopyAirplane.FinishCity;
            StartDate = CopyAirplane.StartDate;
            FinishDate = CopyAirplane.FinishDate;

        }

        public int GetTotalTime()
        {
            int Sum;
            if (StartDate.Year == FinishDate.Year)
            {
                Sum = (FinishDate.Day * 24 * 60 + FinishDate.Hours * 60 + FinishDate.Minutes) - (StartDate.Day * 24 * 60 + StartDate.Hours * 60 + StartDate.Minutes);
            }
            else
            {
                Sum = ((FinishDate.Day+365) * 24 * 60 + FinishDate.Hours * 60 + FinishDate.Minutes) - (StartDate.Day * 24 * 60 + StartDate.Hours * 60 + StartDate.Minutes);
            }
            return Sum;
        }

        public bool IsArrivingToday()
        {
            if (StartDate.Day == FinishDate.Day&&StartDate.Year==FinishDate.Year)
            {
                return true;
            }
            else return false;
        }
        public string StartCity
        {
            set
            {
                _startCity = value;
            }
            get
            {
                return _startCity;
            }
        }
        public string FinishCity
        {
            set
            {
                _finishCity = value;
            }
            get
            {
                return _finishCity;
            }
        }
        public Date StartDate
        {
            set
            {
                _startDate = value;
            }
            get
            {
                return _startDate;
            }
        }
        public Date FinishDate
        {
            set
            {
                _finishDate = value;
            }
            get
            {
                return _finishDate;
            }
        }
    }
}
