using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        protected string _startCity = "Kyiv";
        protected string _finishCity = "Tokio";
        protected Date _startDate = new Date();
        protected Date _finishDate = new Date();
        public string StartCity
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _startCity = value;
                else
                    throw new Exception("Error");

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
                if (!string.IsNullOrEmpty(value))
                    _finishCity = value;

                else
                    throw new Exception("Error");

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

        //по замовчуванню
        public Airplane()
        {

        }
        //не менше двох конструкторів з параметрами
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }
        public Airplane(Date startDate, Date finishDate)
        {
            StartDate = new Date(startDate);
            FinishDate = new Date(finishDate);
        }

        //конструктор копіювання
        public Airplane(Airplane airplane)
        {
            this.StartCity = airplane.StartCity;
            this.FinishCity = airplane.FinishCity;
            this.StartDate = new Date(airplane.StartDate);
            this.FinishDate = new Date(airplane.FinishDate);
        }


        public int GetTotalTime()
        {
            return (int)new DateTime(this.FinishDate.Year, this.FinishDate.Month, this.FinishDate.Day,
                                      this.FinishDate.Hours, this.FinishDate.Minutes, 0) .Subtract
                                      ( new DateTime(this.StartDate.Year, this.StartDate.Month, this.StartDate.Day,
                                      this.StartDate.Hours, this.StartDate.Minutes, 0)).TotalMinutes;
        }
        public bool IsArrivingToday()
        {
            if (_startDate.GetDay == _finishDate.GetDay && _startDate.GetMonth == _finishDate.GetMonth && _startDate.GetYear == _finishDate.GetYear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    }

