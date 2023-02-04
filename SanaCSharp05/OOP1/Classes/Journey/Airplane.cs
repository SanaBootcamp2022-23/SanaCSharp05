using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Classes.Journey
{
    public class Airplane
    {
        protected string startCity = "Київ";
        protected string finishCity = "Житомир";
        protected Date startDate = new Date();
        protected Date finishDate = new Date();

        public string StartCity
        {
            get => startCity;
            set
            {
                if (value.Length >= 4)
                    startCity = value;
            }
        }
        public string FinishCity
        {
            get => finishCity;
            set
            {
                if (value.Length >= 4)
                    finishCity = value;
            }
        }
        public Date StartDate { get => startDate; set => startDate = value; }
        public Date FinishDate
        {
            get => finishDate;
            set
            {
                if (value.Year == startDate.Year)
                {
                    if (value.Month - startDate.Month == 1)
                        finishDate = value;
                    else if (value.Month == startDate.Month &&
                        (value.Day == startDate.Day && (value.Hours > startDate.Hours || value.Hours == startDate.Hours && value.Minutes >= startDate.Minutes)
                        || value.Day > startDate.Day))
                        finishDate = value;
                    else
                        FinishDate = new Date(startDate);
                }
                else if (value.Year - startDate.Year == 1 && value.Month - startDate.Month == -11)
                    finishDate = value;
                else
                    FinishDate = new Date(startDate);

            }
        }

        public Airplane() { }
        public Airplane(string StartCity) : this(StartCity, "Житомир", new Date(), new Date()) { }
        public Airplane(string StartCity, string FinishCity) : this(StartCity, FinishCity, new Date(), new Date()) { }
        public Airplane(string StartCity, string FinishCity, Date StartDate, Date FinishDate)
        {
            this.StartCity = StartCity;
            this.FinishCity = FinishCity;
            this.StartDate = new Date(StartDate);
            this.FinishDate = new Date(FinishDate);
        }
        public Airplane(Airplane airplane) : this(airplane.StartCity, airplane.FinishCity, airplane.StartDate, airplane.FinishDate) { }

        public override string ToString()
        {
            return $"Start City - {StartCity} \tFinish City - {FinishCity} \nStartDate - {StartDate.ToString()} \nFinishDate - {FinishDate.ToString()}\n";
        }

        public int GetTotalTime()
        {
            int countTime = 0;


            if (FinishDate.Year > StartDate.Year)
            {
                countTime += CalcLibrary.CountDayInMonth(StartDate.Month, StartDate.Year) * 1440 - StartDate.Day * 1440 +
                    (1440 - (StartDate.Hours * 60 + StartDate.Minutes));

                countTime += CalcLibrary.CountDayInMonth(FinishDate.Month, FinishDate.Year) * 1440 -
                    (CalcLibrary.CountDayInMonth(FinishDate.Month, FinishDate.Year) * 1440 - FinishDate.Day * 1440) -
                    (1440 - (FinishDate.Hours * 60 + FinishDate.Minutes));
            }
            else
            {
                for (int i = StartDate.Month; i <= FinishDate.Month; i++)
                    countTime += CalcLibrary.CountDayInMonth(i, StartDate.Year) * 1440;


                if (countTime > 0)
                {
                    countTime -= StartDate.Day * 1440;
                    countTime += 1440 - (StartDate.Hours * 60 + StartDate.Minutes);
                    countTime -= CalcLibrary.CountDayInMonth(FinishDate.Month, FinishDate.Year) * 1440 - FinishDate.Day * 1440;
                    countTime -= 1440 - (FinishDate.Hours * 60 + FinishDate.Minutes);
                }
            }

            return countTime;
        }

        public bool IsArrivingToday()
        {
            if (StartDate.Month == FinishDate.Month && StartDate.Day == FinishDate.Day)
                return true;
            return false;
        }

    }
}
