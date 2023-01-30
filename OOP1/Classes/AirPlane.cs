namespace OOP1
{
    public class AirPlane
    {
        public string StartCity { get; set; } = "";
        public string FinishCity { get; set; } = "";
        public Date StartDate { get; set; } = new();
        public Date FinishDate { get; set; } = new();

        public AirPlane() { }

        public AirPlane(string startCity, string finishCity, Date startDate, Date finishDate) : this(startDate, finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }

        public AirPlane(Date startDate, Date finishDate)
        {
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public AirPlane(AirPlane clone)
            : this(clone.StartCity, clone.FinishCity, clone.StartDate, clone.FinishDate)
        { }

        public double GetTotalTime()
        {
            return (FinishDate.ToDateTime() - StartDate.ToDateTime()).TotalMinutes;
        }

        public bool IsArrivaingToday()
        {
            return DateTime.Today <= FinishDate.ToDateTime() && FinishDate.ToDateTime() <= DateTime.Today.AddDays(1);
        }

        public override string ToString()
        {
            return $"{StartCity,-18} {FinishCity,-14} {StartDate,-25} {FinishDate}";
        }
    }

}
