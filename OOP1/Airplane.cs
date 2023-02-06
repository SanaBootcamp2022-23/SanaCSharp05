
namespace OOP1
{
    public class Airplane
    {
        protected string startCity;
        protected string finishCity;
        protected Date startDate;
        protected Date finishDate;
        
        public Airplane()
        {
            startCity = "";
            finishCity = "";
            startDate = new Date();
            finishDate = new Date();
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            this.startCity = startCity;
            this.finishCity = finishCity;
            this.startDate = startDate;
            this.finishDate = finishDate;
        }

        public Airplane(string startCity, string finishCity)
        {
            this.startCity = startCity;
            this.finishCity = finishCity;
            startDate = new Date();
            finishDate = new Date();
        }

        public Airplane(Date startDate, Date finishDate) : this("", "", startDate, finishDate)
        { }

        public Airplane(Airplane otherAirplane)
        {
            this.startCity = otherAirplane.startCity;
            this.finishCity = otherAirplane.finishCity;
            this.startDate = otherAirplane.startDate;
            this.finishDate = otherAirplane.finishDate;
        }

        public string StartCity
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                    startCity = value;
            }
            get { return startCity; }
        }
        public string FinishCity
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                    finishCity = value;
            }
            get { return finishCity; }
        }
        public Date StartDate
        {
            set
            {
                startDate = value;
            }
            get { return startDate; }
        }
        public Date FinishDate
        {
            set
            {
                finishDate = value;
            }
            get
            {
                return finishDate;
            }
        }

        public int GetTotalTime()
        {
            DateTime start = new DateTime(startDate.Year, startDate.Month, startDate.Day, startDate.Hours, startDate.Minutes, 0);
            DateTime finish = new DateTime(finishDate.Year, finishDate.Month, finishDate.Day, finishDate.Hours, finishDate.Minutes, 0);

            TimeSpan duration = finish.Subtract(start);

            int totalTime = Convert.ToInt32(duration.TotalMinutes);
            return totalTime;
        }

        public bool IsArrivingToday()
        {
            if (startDate.Year == finishDate.Year && startDate.Month == finishDate.Month && startDate.Day == finishDate.Day)
                return true;
            return false;
        }
    }
}
