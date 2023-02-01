using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Airplane
    {
        protected string _startCity;
        protected string _finishCity;
        protected Date _startDate = new Date();
        protected Date _finishDate = new Date();
        
        public Airplane() { }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public Airplane(string startCity, string finishCity)
        {
            _startCity = startCity;
            _finishCity = finishCity;
        }
        public string StartCity
        {
            get { return _startCity; }
            set { if (!string.IsNullOrEmpty(value)) _startCity = value; }
        }
        public string FinishCity
        {
            get { return _finishCity; }
            set { if (!string.IsNullOrEmpty(value)) _finishCity = value; }
        }
        public Date StartDate
        {
            get { return _startDate; }
            set
            {
                if (value != null) _startDate = value;
            }
        }
        public Date FinishDate
        {
            get { return _finishDate; }
            set
            {
                if (value != null) _finishDate = value;
            }
        }
        public Airplane(Airplane Air)
        {
            StartCity = Air.StartCity;
            FinishCity = Air.FinishCity;
            StartDate = Air.StartDate;
            StartDate =Air.FinishDate;

        }
        public int GetTotalTime()
        {
            return -_startDate.Total() + _finishDate.Total();
        }
        public bool IsArrivingToday()
        {
            if (_startDate.GetDay == _finishDate.GetDay&& _startDate.GetMonth== _finishDate.GetMonth&& _startDate.GetYear == _finishDate.GetYear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Airplane Copy()
        {
            return new(this);
        }
    }
}
