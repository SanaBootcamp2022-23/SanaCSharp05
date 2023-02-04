namespace ClassLibrary05
{
    public class Airplane
    {
        private string StartCity { get; set; }
        private string FinishCity { get; set; }
        private Date StartDate { get; set; }
        private Date? FinishDate { get; set; }

        public Airplane(Airplane PrevAirplane)
        {
            StartCity = PrevAirplane.StartCity;
            FinishCity = PrevAirplane.FinishCity;
            StartDate = PrevAirplane.StartDate;
            FinishDate = PrevAirplane.FinishDate;
        }

        public Airplane()
        {
            StartCity = "Zhytomyr";
            FinishCity = "Kyiv";
            StartDate = new Date();
            FinishDate = null;
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public void SetStartCity(string startCity) => StartCity = startCity;
        public void SetFinishCity(string finishCity) => FinishCity = finishCity;
        public void SetStartDate(Date startDate) => StartDate = startDate;
        public void SetFinishDate(Date finishDate) => FinishDate = finishDate;
        public string GetStartCity() => StartCity;
        public string GetFinishCity() => FinishCity;
        public Date GetStartDate() => StartDate;
        public Date? GetFinishDate() => FinishDate;
    }
}