using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Airplane
    {
        protected string startCity = "";
        protected string finishCity = "";
        protected Date startDate = new Date();
        protected Date finishDate = new Date();
        
        //Конструктор по замовчуванню
        public Airplane() { }
       
        //Set та Get 
        public string StartCity
        {
            get { return startCity; }
            set { if (!string.IsNullOrEmpty(value)) 
                    startCity = value; 
            }
        }
        public string FinishCity
        {
            get { return finishCity; }
            set { if (!string.IsNullOrEmpty(value)) 
                    finishCity = value; 
            }
        }
        public Date StartDate
        {
            get { return startDate; }
            set { if (value != null) 
                    startDate = new Date(value); 
            }
        }
        public Date FinishDate
        {
            get { return finishDate; }
            set { if (value != null) 
                    finishDate = new Date(value); 
            }
        }
        
        //Конструктори з параметрами
        public Airplane(string startcity, string finishcity, Date startdate, Date finishdate)
        {
            startCity = startcity;
            finishCity = finishcity;
            startDate = startdate;
            finishDate = finishdate;
        }
        public Airplane(string finishcity, Date startdate, Date finishdate)
        {
            finishCity = finishcity;
            startDate = startdate;
            finishDate = finishdate;
        }
        public Airplane(string startcity, string finishcity)
        {
            startCity = startcity;
            finishCity = finishcity;
        }
        
        //Конструктор копіювання
        public Airplane(Airplane copied) : this(copied.startCity, copied.finishCity, copied.startDate, copied.finishDate)
        {

        }
       
        //Методи
        public int? GetTotalTime()
        {
            int totalTime, yearsInMin, monthsInMin, daysInMin, hoursInMin, minutes;
            if (StartDate.Years <= FinishDate.Years && StartDate.Months <= FinishDate.Months && StartDate.Days <= FinishDate.Days)
            {
                yearsInMin = (FinishDate.Years - StartDate.Years) * 525600;
                monthsInMin = (FinishDate.Months - StartDate.Months) * 43800;
                daysInMin = (FinishDate.Days - StartDate.Days) * 1440;
                hoursInMin = (FinishDate.Hours - StartDate.Hours) * 60;
                minutes = FinishDate.Minutes - StartDate.Minutes;
                totalTime = yearsInMin + monthsInMin + daysInMin + hoursInMin + minutes;
                return totalTime;
            }
            else return null;  
        }

        public bool? IsArrivingToday()
        {
            if (StartDate.Years == FinishDate.Years && StartDate.Months == FinishDate.Months && StartDate.Days == FinishDate.Days)
                return true;
            return false;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Місто відправлення: {startCity}");
            Console.WriteLine($"Місто прибуття: {finishCity}");
            Console.WriteLine($"Час та дата відправлення: {StartDate.Hours}:{StartDate.Minutes} {StartDate.Days}.{StartDate.Months}.{StartDate.Years}");
            Console.WriteLine($"Час та дата прибуття: {FinishDate.Hours}:{FinishDate.Minutes} {FinishDate.Days}.{FinishDate.Months}.{FinishDate.Years}");
            Console.WriteLine($"Час польоту у хвилинах: {GetTotalTime()}");
            Console.WriteLine($"Прибуття сьогодні? {IsArrivingToday()}");
            Console.WriteLine();
        }
    }
}
