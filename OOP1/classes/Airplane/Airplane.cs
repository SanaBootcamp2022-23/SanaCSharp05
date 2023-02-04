namespace OOP1.classes.Airplane
{
    public class Airplane
    {
        protected string StartCity;
        public string startCity
        {
            get { return StartCity; }
            set { StartCity = value; }
        }

        protected string FinishCity;
        public string finishCity
        {
            get { return FinishCity; }
            set { FinishCity = value; }
        }

        protected Date StartDate;
        public Date startDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        protected Date FinishDate;
        public Date finishDate
        {
            get { return finishDate; }
            set { FinishDate = value; }
        }

        //default constructor
        public Airplane()
        {
            StartCity = "Zhytomyr";
            FinishCity = "Donbas";
            StartDate = new Date();
            StartDate = new Date(StartDate.day + 1, StartDate.hours);
        }

        //parameterized constructor
        public Airplane(string StartCity, string FinishCity, Date StartDate, Date FinishDate)
        {
            this.StartCity = StartCity;
            this.FinishCity = FinishCity;
            if (StartDate.IsEarlier(FinishDate))
            {
                throw new Exception("start date must be earlier than finish date");
            }
            this.StartDate = StartDate;
            this.FinishDate = FinishDate;
        }

        //parameterized constructor 2
        public Airplane(string StartCity, string FinishCity)
        {
            this.StartCity = StartCity;
            this.FinishCity = FinishCity;
            StartDate = new Date();
            StartDate = new Date(StartDate.day + 1, StartDate.hours);
        }

        //copy constructor
        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = airplane.StartDate;
            FinishDate = airplane.FinishDate;
        }

        public double GetTotalTime()
        {
            DateTime date1 = new DateTime(StartDate.year, StartDate.month, StartDate.day, StartDate.hours, StartDate.minutes, 0);
            DateTime date2 = new DateTime(FinishDate.year, FinishDate.month, FinishDate.day, FinishDate.hours, FinishDate.minutes, 0);
            TimeSpan ts = date2 - date1;
            return ts.TotalMinutes;
        }

        public bool IsArrivingToday()
        {
            return StartDate.day == FinishDate.day;
        }
    }
}