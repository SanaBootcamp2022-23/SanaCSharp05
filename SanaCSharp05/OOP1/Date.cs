using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public Date()
        {
            Year= 2023;
            Month = 2;
            Day = 2;
            Hours =22;
            Minutes = 30;
        }
        public Date(int Year,int Month,int Day)
        {
            this.Year= Year;
            this.Month = Month;
            this.Day = Day;
        }public Date(int Year,int Month,int Day,int Hours,int Minutes)
        {
            this.Year= Year;
            this.Month = Month;
            this.Day = Day;
            this.Hours = Hours;
            this.Minutes = Minutes;
        }
        public Date(Date obj)
        {
            Year= obj.Year;
            Month= obj.Month;
            Day= obj.Day;
            Hours = obj.Hours;
            Minutes = obj.Minutes;
        }
        public static bool operator >(Date tmp1,Date tmp2)
        {
            if(tmp1.Year>tmp2.Year) 
                return true;
            if (tmp1.Month > tmp2.Month)
                return true;
            if (tmp1.Day > tmp2.Day)
                return true;
            if (tmp1.Hours > tmp2.Hours)
                return true;
            if (tmp1.Minutes > tmp2.Minutes)
                return true;
            return false;
        }
        public static bool operator <(Date tmp1, Date tmp2)
        {
            if (tmp1.Year < tmp2.Year)
                return true;
            if (tmp1.Month < tmp2.Month)
                return true;
            if (tmp1.Day < tmp2.Day)
                return true;
            if (tmp1.Hours < tmp2.Hours)
                return true;
            if (tmp1.Minutes < tmp2.Minutes)
                return true;
            return false;
        }
    }
}
