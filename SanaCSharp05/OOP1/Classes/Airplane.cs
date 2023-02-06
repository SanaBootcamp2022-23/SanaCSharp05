namespace OOP1.Classes
{
    public class Airplane
    {
        protected string startCity;
        protected string finishCity;
        protected Date startDate;
        protected Date finishDate;


        public string StartCity
        {
            get { return startCity; }
            set
            {
                startCity = value ?? string.Empty;
            }
        }

        public string FinishCity
        {
            get { return finishCity; }
            set
            {
                finishCity = value ?? string.Empty;
            }
        }
        public Date StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value ?? new Date();
            }
        }
        public Date FinishDate
        {
            get { return finishDate; }
            set
            {
                finishDate = value ?? new Date();
            }
        }

        public Airplane()
        {
            StartCity = "Kyiv";
            FinishCity = "Lviv";
        }
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
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public Airplane(Date startDate, string startCity)
        {
            StartDate = startDate;
            StartCity = startCity;
        }
        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = airplane.StartDate;
            FinishDate = airplane.FinishDate;
        }



        public double GetTotalTime()
        {
            var _startDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day,
                StartDate.Hours, StartDate.Minutes, 0);
            var _finishtDate = new DateTime(FinishDate.Year, FinishDate.Month, FinishDate.Day,
                            FinishDate.Hours, FinishDate.Minutes, 0);

            var diff = _finishtDate.Subtract(_startDate);




            return diff.TotalMinutes;
        }

        public bool IsArrivingToday()
        {
            if (StartDate.Day == FinishDate.Day && StartDate.Month == FinishDate.Month
                && StartDate.Year == FinishDate.Year)
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
