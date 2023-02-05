using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Date
    {
        // поля оголошено(захищені) 3.1
        protected int year;
        protected int month;
        protected int day;
        protected int hours;
        protected int minutes;

        // сетери та гетери 3.3
        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }
        public int Day { get => day; set => day = value; }
        public int Hours { get => hours; set => hours = value; }
        public int Minutes { get => minutes; set => minutes = value; }

        public Date()
        {
         //конструктор по замовчуванню 3.2
        }

        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
         //конструктор з параметрами 3.2
        }
        public Date(int year, int month,int day)
        {
               Year= year;
               Month = month;
               Day = day;
         //конструктор з параметрами 3.2
        }


        public Date(Date copyDate)
        {
            Year = copyDate.Year;
            Month = copyDate.Month;
            Day = copyDate.Day;
            Hours = copyDate.Hours;
            Minutes = copyDate.Minutes;
            //конструктор з параметрами 3.2
        }

        public int TimeInMinutes()
        {
            int TotalMinutes = Minutes;
            TotalMinutes +=  60* Hours;
            TotalMinutes += 24 * 60 * Day;
            TotalMinutes += 30 * 24 * 60 * Month;
            TotalMinutes += 12 * 30 * 24 * 60 * Year;
            return TotalMinutes;
            //допоміжний метод для отримання загальної кількості хвилин 3.4
        }

        public Date(DateTime Now)
        {
            Year = Now.Year;
            Month = Now.Month;
            Day = Now.Day;
            Hours = Now.Hour;
            Minutes =Now.Minute;
        }

        public void PrintDate()
        {
            Console.WriteLine($"Your trip has sheduled for {Year} {Month} {Day} {Hours} {Minutes}");
        }
    }
}
