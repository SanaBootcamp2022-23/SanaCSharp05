using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Airplane
    {
        // поля оголошено(захищені) 3.1
        protected string startCity;
        protected string finishCity;
        protected Date startDate;
        protected Date finishDate;

        // сетери та гетери 3.3
        public string StartCity { get => startCity; set => startCity = value; }
        public string FinishCity { get => finishCity; set => finishCity = value; }
        public Date StartDate { get => startDate; set => startDate = value; }
        public Date FinishDate { get => finishDate; set => finishDate = value; }

   


        public Airplane()
        { // конструктор по замовчуванню 3.2
            startCity = "";
            finishCity = "";
            startDate = new Date();
            finishDate = new Date();
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate) 
        { // конструктор з параметрами 3.2
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(Date startDate,Date finishDate)
        {// конструктор з параметрами 3.2
           StartDate = startDate; 
           FinishDate= finishDate;
        }

        public Airplane(Airplane copyAirplane)
        {
            StartDate = copyAirplane.startDate;
            FinishCity = copyAirplane.finishCity;
            FinishDate = copyAirplane.startDate;
            FinishDate= copyAirplane.finishDate;
            // конструктор копіювання 3.2
        }
        public int GetTotalTime()
        { // сумарний час подорожі 3.4
            Console.Write("Ваша подорож буде тривати:");
            return finishDate.TimeInMinutes() - startDate.TimeInMinutes() ;
        }
         
        public bool IsArrivingToday()
        { // метод який перевіряє чи відбувається відправлення і прибуття в той же день 3.4
            if (
                    startDate.Year == finishDate.Year &&
                    startDate.Month == finishDate.Month &&
                    startDate.Day == finishDate.Day
               )
                return true;
            else
                return false;

        }
    }
}
