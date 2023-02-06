using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Airplane
    {
        TimeSpan interval = new TimeSpan();


        private Date _startDate = new Date();
        private Date _finishDate = new Date();
        private string _startCity = "StartCiy";
        private string _finishCity = "FinishCity";
        public Airplane()
        {

        }
        public Airplane(Date startDate, string startCity)
        {
            _startCity = startCity;
            _startDate = startDate;
        }

        public Airplane(Date startDate, Date finishDate, string finishCity, string startCity)
        {
            _startCity = startCity;
            _startDate = startDate;
            _finishDate = finishDate;
            _finishCity = finishCity;
        }
        public string StartCity
        {
            get => _startCity;
            set
            {
                if (value != "")
                {
                    _startCity = value;
                }
            }
        }
        public string FinishCity
        {
            get => _finishCity;
            set
            {
                if (value != "")
                {
                    _finishCity = value;
                }
            }
        }

        public Date StartDate
        {
            get => _startDate;
            set
            {
                _startDate = new Date(value);
            }
        }
        public Date FinishDate
        {
            get => _finishDate;
            set
            {
                _finishDate = new Date(value);
            }
        }
        public double GetTotalTime()
        {
            DateTime start = new DateTime(_startDate.Year, _startDate.Month, _startDate.Day, _startDate.Hours, _startDate.Minutes, 0);
            DateTime finish = new DateTime(_finishDate.Year, _finishDate.Month, _finishDate.Day, _finishDate.Hours, _finishDate.Minutes, 0);
            interval = finish - start;

            return interval.TotalMinutes;

        }
        public bool IsArrivingToday() 
        {
            if (_startDate.Day == _finishDate.Day) 
            {
                return true;
            }
            return false;
        }
    }
}
    