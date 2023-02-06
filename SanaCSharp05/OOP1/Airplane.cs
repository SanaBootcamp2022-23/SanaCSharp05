using OOP1;

    public class Airplane
    {
        private string _startCity = "Washington ";
        public string StartCity
        {
            get { return _startCity; }
            set { _startCity = !string.IsNullOrEmpty(value) ? value : throw new Exception("Error"); }
        }
        private string _finishCity = "Kyiv";
        public string FinishCity
        {
            get { return _finishCity; }
            set { _finishCity = !string.IsNullOrEmpty(value) ? value : throw new Exception("Error"); }
        }
        private Date _startDate;
        public Date StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        private Date _finishDate;
        public Date FinishDate
        {
            get { return _finishDate; }
            set { _finishDate = value.Year >= _startDate.Year ? value : _finishDate; }
        }

        public Airplane()
        {
            StartCity = "Washington ";
            FinishCity = "Kyiv";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(string startCity, string finishCity, Date startDate) : this(startCity, finishCity)
        {
            StartDate = startDate;
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate) : this(startCity, finishCity, startDate)
        {
            FinishDate = finishDate;
        }
        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = obj.StartDate;
            FinishDate = obj.FinishDate;
        }
        public double GetTotalTime()
        {
            double result = (FinishDate.Year - StartDate.Year) * 365 * 24 * 60;
            result += (FinishDate.Months - StartDate.Months) * 365 / 12 * 24 * 60;
            result += (FinishDate.Days - StartDate.Days) * 24 * 60;
            result += (FinishDate.Hours - StartDate.Hours) * 60;
            result += FinishDate.Minutes - StartDate.Minutes;
            return result;
        }
        public bool IsArrivingToday(Date startDate, Date finishDate)
        {
            return startDate.Year == finishDate.Year && startDate.Days == finishDate.Days && startDate.Months == finishDate.Months;
        }
    }

