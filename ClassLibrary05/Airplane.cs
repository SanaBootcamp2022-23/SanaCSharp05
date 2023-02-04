namespace ClassLibrary05
{
    public class Airplane
    {
        protected string StartCity { get; set; }
        protected string FinishCity { get; set; }
        protected Date StartDate { get; set; }
        protected Date? FinishDate { get; set; }

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


        public int GetTotalTime()
        {
            int StartDateInMinutes = 0, FinishDateInMinutes = 0;

            if (FinishDate?.GetYear() != null && FinishDate?.GetMonth() != null)
            {
                int StartDateYearInMinutes = (DateTime.IsLeapYear(StartDate.GetYear()) ? 366 : 365) * 24 * 60;
                int StartDateMonthInMinutes = DateTime.DaysInMonth(StartDate.GetYear(), StartDate.GetMonth()) * 24 * 60;
                int StartDateDaysInMinutes = StartDate.GetDay() * 24 * 60;
                int StartDateHoursInMinutes = StartDate.GetHours() * 60;
                int StartDateMinutes = StartDate.GetMinutes();
                StartDateInMinutes = StartDateYearInMinutes + StartDateMonthInMinutes + StartDateDaysInMinutes + StartDateHoursInMinutes + StartDateMinutes;
                
                int FinishDateYearInMinutes = (DateTime.IsLeapYear(FinishDate.GetYear()) ? 366 : 365) * 24 * 60;
                int FinishDateMonthInMinutes = DateTime.DaysInMonth(FinishDate.GetYear(), FinishDate.GetMonth()) * 24 * 60;
                int FinishDateDaysInMinutes = FinishDate.GetDay() * 24 * 60;
                int FinishDateHoursInMinutes = FinishDate.GetHours() * 60;
                int FinishDateMinutes = FinishDate.GetMinutes();
                StartDateInMinutes = FinishDateYearInMinutes + FinishDateMonthInMinutes + FinishDateDaysInMinutes + FinishDateHoursInMinutes + FinishDateMinutes;
            }

            int TotalTime = FinishDateInMinutes - StartDateInMinutes;
            return TotalTime;
        }

        public bool IsArrivingToday() => FinishDate?.GetDay() != null ? StartDate.GetDay() == FinishDate.GetDay() ? true : false : false;
    }
}