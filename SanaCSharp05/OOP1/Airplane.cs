using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        private string _startCity = "Unknown City";
        private string _finishCity = "Unknown City";
        private Date _startDate = new();
        private Date _finishDate = new();

        //властивості
        public string StartCity
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _startCity = value;
            }
            get { return _startCity; }
        }
        public string FinishCity
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _finishCity = value;
            }
            get { return _finishCity; }
        }
        public Date StartDate
        {
            set { _startDate = value; }
            get { return _startDate; }
        }
        public Date FinishDate
        {
            set { _finishDate = value; }
            get { return _finishDate; }
        }

        //по замовчуванню
        public Airplane() { }
        //конструктори з параметрами
        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }

        public Airplane(Date startDate, Date finishDate)
        {
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        //конструктор копіювання
        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = airplane.StartDate.Copy();
            FinishDate = airplane.FinishDate.Copy();
        }
        public Airplane Copy()
        {
            return new(this);
        }

        //сумарний час подорожі у хвилинах
        public int GetTotalTime()
        {
            return (int)(FinishDate.AllTime() - StartDate.AllTime());
        }
        //чи відправлення і прибуття в той же день
        public bool IsArrivingToday()
        {
            return StartDate.Year == FinishDate.Year
                && StartDate.Month == FinishDate.Month
                && StartDate.Day == FinishDate.Day;
        }
    }
    
    
}
