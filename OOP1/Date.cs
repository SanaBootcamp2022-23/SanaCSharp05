namespace OOP1
{
    class Date
    {
        protected int _Year;
        protected int _Month;
        protected int _Day;
        protected int _Hours;
        protected int _Minutes;
        public Date()
        {
            _Year = DateTime.Now.Year;
            _Month = DateTime.Now.Month;
            _Day = DateTime.Now.Day;
            _Hours = DateTime.Now.Hour;
            _Minutes = DateTime.Now.Minute;
        }
        public Date(int year, int month, int day, int hours, int minutes)
        {
            _Year = year;
            _Month = month;
            _Day = day;
            _Hours = hours;
            _Minutes = minutes;
        }
        public Date(Date obj)
        {
            _Year = obj._Year;
            _Month = obj._Month;
            _Day = obj._Day;
            _Hours = obj._Hours;
            _Minutes = obj._Minutes;
        }
        public Date(Date obj, int addDays)
        {
            DateTime time = new DateTime(obj._Year, obj._Month, obj._Day, obj._Hours, obj._Minutes, 0);
            time.AddDays(addDays);
            _Year = time.Year;
            _Month = time.Month;
            _Day = time.Day;
            _Hours = time.Hour;
            _Minutes = time.Minute;
        }
        public int Year
        {
            set { _Year = value; }
            get { return _Year; }

        }
        public int Month
        {
            set { _Month = value; }
            get { return _Month; }
        }
        public int Day
        {
            set { _Day = value; }
            get { return _Day; }
        }
        public int Hours
        {
            set { _Hours = value; }
            get { return _Hours; }
        }
        public int Minutes
        {
            set { _Minutes = value; }
            get { return _Minutes; }
        }

    }

}
