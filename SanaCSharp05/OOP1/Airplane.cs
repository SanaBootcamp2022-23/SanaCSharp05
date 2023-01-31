namespace OOP1
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;

        public Airplane()
        {
            StartCity = "Kiev";
            FinishCity = "Los-Angeles";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(string startCity)
        {
            StartCity = startCity;
        }
        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }
        public Airplane(string startCity, string finishCity, Date startDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = new Date(obj.StartDate);
            FinishDate = new Date(obj.FinishDate);
        }

        public string GetStartCity()
        {
            return StartCity; 
        }
        public string GetFinishCity()
        {
            return FinishCity;
        }
        public Date GetStartDate()
        {
            return StartDate;
        }
        public Date GetFinishDate()
        {
            return FinishDate;
        }
        public void SetStartCity(string startCity)
        {
            if (!string.IsNullOrEmpty(startCity))
            {
                StartCity = startCity;
            }
        }
        public void SetFinishCity(string finishCity)
        {
            if (!string.IsNullOrEmpty(finishCity))
            {
                FinishCity = finishCity;
            }
        }
        public void SetStartDate(Date startDate)
        {
            StartDate = startDate;
        }
        public void SetFinishDate(Date finishDate)
        {
            FinishDate = finishDate;
        }

        public int GetTotalTime()
        {
            int HourFinishDate = GetFinishDate().GetHours();
            int HourStartDate = GetStartDate().GetHours();
            int MinutesStartDate = GetStartDate().GetMinutes();
            int MinutesFinishDate = GetFinishDate().GetMinutes();
            int DifferenceInDay = GetFinishDate().GetDay() - GetStartDate().GetDay();
            int DifferenceInMounth = GetFinishDate().GetMonth() - GetStartDate().GetMonth();
            int DifferenceInYear = GetFinishDate().GetYear() - GetStartDate().GetYear();
            int TotalTime = (DifferenceInYear * 525960) + (DifferenceInMounth * 43800) + (DifferenceInDay * 1440) + ((HourFinishDate - HourStartDate) * 60) + (MinutesFinishDate - MinutesStartDate);

            return TotalTime;
        }
        public bool IsArrivingToday(Airplane ArrivalDay)
        {
            if (ArrivalDay.GetStartDate().GetYear() == ArrivalDay.GetFinishDate().GetYear() && ArrivalDay.GetStartDate().GetMonth() == ArrivalDay.GetFinishDate().GetMonth() && ArrivalDay.GetStartDate().GetDay() == ArrivalDay.GetFinishDate().GetDay())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}