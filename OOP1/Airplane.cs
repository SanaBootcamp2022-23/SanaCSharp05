namespace OOP1
{
    class Airplane
    {
        protected string _StartCity;
        protected string _FinishCity;
        protected Date _StartDate;
        protected Date _FinishDate;
        public Airplane()
        {
            _StartCity = "Гіран";
            _FinishCity = "Коноха";
            _StartDate = new Date();
            _FinishDate = new Date(_StartDate, 1);
        }
        public Airplane(string startCity, string finishCity)
        {
            _StartCity = startCity;
            _FinishCity = finishCity;
            _StartDate = new Date();
            _FinishDate = new Date(_StartDate, 1);
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            _StartCity = startCity;
            _FinishCity = finishCity;
            _StartDate = startDate;
            _FinishDate = finishDate;
        }
        public Airplane(Airplane obj)
        {
            _StartCity = obj._StartCity;
            _FinishCity = obj._FinishCity;
            _StartDate = obj._StartDate;
            _FinishDate = obj._FinishDate;
        }
        public string StartCity
        {
            set { _StartCity = value; }
            get { return _StartCity; }
        }
        public string FinishCity
        {
            set { _FinishCity = value; }
            get { return _FinishCity; }
        }
        public Date StartDate
        {
            set { _StartDate = value; }
            get { return _StartDate; }
        }
        public Date FinishDate
        {
            set { _FinishDate = value; }
            get { return _FinishDate; }
        }
        public int GetTotalTime(Date startDate, Date finishDate)
        {

            DateTime start = new DateTime(startDate.Year, startDate.Month, startDate.Day, startDate.Hours, startDate.Minutes, 0);
            DateTime end = new DateTime(finishDate.Year, finishDate.Month, finishDate.Day, finishDate.Hours, finishDate.Minutes, 0);
            TimeSpan diff = end - start;
            int result = (int)diff.TotalMinutes;
            return result;
        }
        public bool IsArrivingToday(Date startDate, Date finishDate)
        {
            if (startDate.Year == finishDate.Year && startDate.Month == finishDate.Month && startDate.Day == finishDate.Day) return true;
            return false;
        }
    }
}
