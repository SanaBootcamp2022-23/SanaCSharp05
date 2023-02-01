namespace ClassLibraryOOP1
{
    public class Airplane
    {
        protected string? StartCity;
        protected string? FinishCity;
        protected Date StartDate;
        protected Date FinishDate;

        public Airplane() 
        { 
            this.StartDate = new Date();
            this.FinishDate = new Date();
            this.StartCity = null;
            this.FinishCity = null;
        }

        public Airplane(string startCity, string finsihCity, Date startDate, Date finishDate)
        { 
            this.StartDate = startDate;
            this.FinishDate = finishDate;
            this.StartCity = startCity;
            this.FinishCity = finsihCity;
        }
        public Airplane(string startCity, string finsihCity, int startYear, int startMonth,
            int startDay, int finishYear, int finishMonth, int finishDay)
        {
            this.StartCity = startCity;
            this.FinishCity = finsihCity;
            this.StartDate = new Date(startYear, startMonth, startDay);
            this.FinishDate = new Date(finishYear, finishMonth, finishDay);
        }

        public Airplane(Airplane previousAirplane)
        { 
            this.StartDate = previousAirplane.StartDate;
            this.FinishDate = previousAirplane.FinishDate;
            this.FinishCity = previousAirplane.FinishCity;
            this.StartDate = previousAirplane.StartDate;
        }

        public double GetTotalTime()
        {
            TimeSpan result = FinishDate.GetFullDate() - StartDate.GetFullDate();
            return result.TotalMinutes;
        }

        public bool IsArrivingToday()
        { 
            if(StartDate.day == FinishDate.day && StartDate.month == FinishDate.month && StartDate.year == FinishDate.year)
                return true;
            else
                return false;
        }

        public string? finishCity
        {
            set { FinishCity = value; }
            get { return FinishCity; }
        }

        public string? startCity
        {
            set { StartCity = value; }
            get { return StartCity; }
        }

        public Date finishDate
        { 
            set { FinishDate = value; }
            get { return FinishDate; }
        }

        public Date startDate
        {
            set { StartDate = value; }
            get { return StartDate; }
        }
    }
}