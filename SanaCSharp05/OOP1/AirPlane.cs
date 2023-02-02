using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class AirPlane
    {
        public Cities StartCity { get; set; }

        public Cities FinishCity { get; set; }

        public Date StartDate { get; set; }

        public Date FinishDate { get; set; }


        public AirPlane()
        {
            StartCity = Cities.None;
            FinishCity = Cities.None;

            StartDate = new Date();
            FinishDate = new Date();
        }

        public AirPlane(Cities startCity, Cities finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public AirPlane(Cities startCity, Cities finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;

            StartDate = new Date();
            FinishDate = new Date();
        }

        public AirPlane(AirPlane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = obj.StartDate;
            FinishDate = obj.FinishDate;
        }

        /*time in minutes*/
        public double GetTotalTime()
        {
            /*long time = 0;

            time += FinishDate.Year - StartDate.Year;
            time *= 12; // convert to month

            time += Math.Abs(FinishDate.Month - StartDate.Month);
            time *= 30; //convert to days

            time += Math.Abs(FinishDate.Day - StartDate.Day);
            time *= 24; // convert to hours;

            time += Math.Abs(FinishDate.Hours - StartDate.Hours);
            time *= 60; // convert to minutes

            time += Math.Abs(FinishDate.Minutes - StartDate.Minutes);

            return time;*/ //old solution


            //with DateTime struct
            Date b = StartDate, a = FinishDate;
            double travelTime = (new DateTime(a.Year, a.Month, a.Day, a.Hours, a.Minutes, 0)
                - new DateTime(b.Year, b.Month, b.Day, b.Hours, b.Minutes, 0)).TotalMinutes;

            return travelTime;
        }

        public bool IsArrrivingToday() => StartDate.Year == FinishDate.Year &&
            StartDate.Month == FinishDate.Month &&
            StartDate.Day == FinishDate.Day;
    }
}
