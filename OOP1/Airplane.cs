using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        public string StartCity { get; set; }
        public string FinishCity { get; set; }
        public Date StartDate { get; set; }
        public Date FinishDate { get; set; }

        public Airplane()
        {
            StartCity = "Kyiv";
            FinishCity = "London";
            StartDate = new Date(2023, 1, 31, 14, 30);
            FinishDate = new Date(2023, 1, 31, 22, 30);
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(string startCity,string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }

        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = airplane.StartDate;
            FinishDate = airplane.FinishDate;
        }

        public int GetTotalTime(Date startDate, Date finishDate)
        {
            var totalTime = (finishDate.Day - startDate.Day) * 60 * 24 + (finishDate.Hours - startDate.Hours) * 60 + (finishDate.Minutes - startDate.Minutes);
            return totalTime;
        }

        public bool IsArrivingToday(Date date1, Date date2)
        {
            if (date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day)
            {
                return true;
            }
            return false;
        }

    }

}
