using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        public string StartCity { get; set; } = "StartCity";
        public string FinishCity { get; set; } = "FinishCity";
        public Date StartDate { get; set; } = new Date();
        public Date FinishDate { get; set; } = new Date();

        public Airplane()
        {
            
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public Airplane(string startCity, string finishCity, Date startDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;           
        }
        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity; 
            FinishCity = airplane.FinishCity;   
            StartDate = new Date(airplane.StartDate);
            FinishDate = new Date(airplane.FinishDate);            
        }
        
        public bool IsArrivingToday()
        {
            return StartDate.Day == FinishDate.Day;
        }

        
        public uint GetTotalTime()
        {
            
            DateTime finish = new DateTime((int)FinishDate.Year, (int)FinishDate.Month, (int)FinishDate.Day,(int)FinishDate.Hours,(int)FinishDate.Minutes,0);

            DateTime start = new DateTime((int)StartDate.Year, (int)StartDate.Month, (int)StartDate.Day,(int)StartDate.Hours, (int)StartDate.Minutes, 0);

            
            var result = finish - start;

            return (uint)result.TotalMinutes;
        }
    }
}
