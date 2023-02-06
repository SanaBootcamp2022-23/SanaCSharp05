namespace OOP1
{
    public class Airplane
    {
        private string startCity;
        private string finishCity;
        private Date startDate;
        private Date finishDate;

        public string StartCity { get => startCity; set => startCity = value; }
        public string FinishCity { get => finishCity; set => finishCity = value; }
        public Date StartDate { get => startDate; set => startDate = value; }
        public Date FinishDate { get => finishDate; set => finishDate = value; }

        public Airplane()
        {
            StartCity = "Unknown";
            FinishCity = "Unknown";
            StartDate = null;
            FinishDate = null;
        }

        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate) : this(startCity, finishCity)
        {
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = obj.StartDate;
            FinishDate = obj.FinishDate;
        }

        public bool IsArrivingToday() => StartDate.IsDateEqual(FinishDate);

        public long GetTotalTime() => FinishDate.ToMinutes() - StartDate.ToMinutes();
    }
}
