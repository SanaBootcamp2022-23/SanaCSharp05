using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP1;

namespace OOP1
{
    class Airplane
    {

        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;


        public Airplane()
        {
            StartCity = "Empty";
            FinishCity = "Empty";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(string StartCity, string FinishCity)
        {
            this.StartCity = StartCity;
            this.FinishCity = FinishCity;
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(string StartCity, string FinishCity, uint StartYear, byte StartMonth, byte StartDay, uint FinishYear, byte FinishMonth, byte FinishDay, byte StartHours, byte StartMinutes, byte FinishHours, byte FinishMinutes) : this(StartCity, FinishCity)
        {

            StartDate = new Date(StartYear, StartMonth, StartDay, StartHours, StartMinutes);
            FinishDate = new Date(FinishYear, FinishMonth, FinishDay, FinishHours, FinishMinutes);

        }
        public Airplane(Airplane CreatedObject)
        {
            StartCity = CreatedObject.StartCity;
            FinishCity = CreatedObject.FinishCity;
            StartDate = CreatedObject.StartDate;
            FinishDate = CreatedObject.FinishDate;
        }
        public string startCity
        {
            get { return StartCity; }
            set { StartCity = value; }
        }
        public string finishtCity
        {
            get { return FinishCity; }
            set { FinishCity = value; }
        }
        public int GetTotalTime()
        {
            int result;
            uint tempYear = FinishDate.year - StartDate.year;
            int tempMonth = FinishDate.month - StartDate.month;
            int tempDay = FinishDate.day - StartDate.day;
            int tempHour = FinishDate.hours - StartDate.hours;
            int tempMinute = FinishDate.minutes - StartDate.minutes;

            result = ((int)tempYear * 365 * 24 * 60) + (tempMonth * 28 * 24 * 60) + (tempDay * 24 * 60) + (tempHour * 60) + tempMinute;

            return result;
        }
        public bool IsArrivingToday()
        {
            if (FinishDate.year - StartDate.year == 0 && FinishDate.month - StartDate.month == 0 && FinishDate.day - StartDate.day == 0)
            {
                return true;
            }
            else
                return false;
        }
        public void GetTotalInfo()
        {
            Console.WriteLine($"Start location: {StartCity}");
            Console.WriteLine($"Finish location: {FinishCity}");
            Console.WriteLine($"Start time: {StartDate.FullDateInfo}");
            Console.WriteLine($"Arriving time: {FinishDate.FullDateInfo}");
            Console.WriteLine($"Total trip time: {GetTotalTime()}");
            Console.WriteLine($"Is arriving today: {IsArrivingToday()}");

        }
    }
}