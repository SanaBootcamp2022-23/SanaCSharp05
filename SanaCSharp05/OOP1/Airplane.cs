namespace OOP1
{
    public class Airplane
    {
        protected string StartCity { get; set; }
        protected string FinishCity { get; set; }
        protected Date? StartDate { get; set; }
        protected Date? FinishDate { get; set; }

        public Airplane()
        {
            StartCity = "";
            FinishCity = "";
            StartDate = null;
            FinishDate = null;
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

        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = airplane.StartDate;
            FinishDate = airplane.FinishDate;
        }

        public int? GetTotalTime()
        {
            return FinishDate.GetTotalMinutes() - StartDate.GetTotalMinutes();
        }

        public bool IsArrivingToday()
        {
            return GetTotalTime() > (24 * 60);
        }
    }
}