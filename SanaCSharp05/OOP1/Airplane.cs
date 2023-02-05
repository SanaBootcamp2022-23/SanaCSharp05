namespace OOP1
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;

        public string startCity
        {
            get { return StartCity; }
            set { if (value != string.Empty) { StartCity = value; } }
        }
        public string finishCity
        {
            get { return FinishCity; }
            set { if (value != string.Empty) { FinishCity = value; } }
        }

        public Date startDate { get { return StartDate; } set { if (value != null) { StartDate = value; } } }

        public Date finishDate { get { return FinishDate; } set { if (value != null) { FinishDate = value; } } }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane() : this("Start is undefined", "Finish is undefined", new Date(), new Date() )
        {}

        public Airplane(Airplane airplane) :this(airplane.StartCity,airplane.FinishCity,airplane.startDate,airplane.finishDate)
        {}

        public Airplane(string startCity, string finishCity):this(startCity,finishCity,new Date(),new Date()) { }

        public double GetTotalTime()
        {
            DateTime start = new DateTime(StartDate.year, StartDate.month, StartDate.day, StartDate.hours, StartDate.minutes, StartDate.seconds);
            DateTime finish = new DateTime(FinishDate.year, FinishDate.month, FinishDate.day, FinishDate.hours, FinishDate.minutes, FinishDate.seconds);

            return finish.Subtract(start).TotalMinutes;
        }

        public bool IsArrivingToday()
        {
            if (StartDate.year == FinishDate.year && StartDate.month == FinishDate.month && StartDate.day == FinishDate.day)
            {
                return true;
            }
            return false;
        }

    }
}
