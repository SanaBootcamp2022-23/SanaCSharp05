namespace OOP1
{
    class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;

        public Airplane()
        {
            StartCity = "Kyiv";
            FinishCity = "London";
            StartDate = new Date();
            FinishDate = new Date();
        }

        public Airplane(string startCity, string finishCity)
        {
            this.StartCity = startCity;
            this.FinishCity = finishCity;
            StartDate = new Date();
            FinishDate = new Date();
        }

        public Airplane(Date startDate, Date finishDate)
        {
            this.StartDate = startDate;
            this.FinishDate = finishDate;
            StartCity = "Lviv";
            FinishCity = "Berlin";
        }

        public Airplane(string startCity,
            string finishCity,
            Date startDate,
            Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = new Date(airplane.StartDate);
            FinishDate = new Date(airplane.FinishDate);
        }

        public void setStartCity(string startCity)
        {
            if (startCity.Length > 0)
                StartCity = startCity;
        }

        public void setFinishCity(string finishCity)
        {
            if (finishCity.Length > 0)
                FinishCity = finishCity;
        }

        public void setStartDate(Date sDate)
        {
            if (sDate != null)
                StartDate = sDate;
        }

        public void setFinishDate(Date fDate)
        {
            if (fDate != null)
                FinishDate = fDate;
        }

        public string getStartCity()
        {
            return StartCity;
        }

        public string getFinishCity()
        {
            return FinishCity;
        }

        public Date getStartDate()
        {
            return StartDate;
        }

        public Date getFinishDate()
        {
            return FinishDate;
        }

        public uint GetTotalTime()
        {
            DateTime startDate = new DateTime(StartDate.getYear(),
                StartDate.getMonth(),
                StartDate.getDay(),
                StartDate.getHours(),
                StartDate.getMinutes(), 0);
            DateTime finishDate = new DateTime(FinishDate.getYear(),
                FinishDate.getMonth(),
                FinishDate.getDay(),
                FinishDate.getHours(),
                FinishDate.getMinutes(), 0);
            TimeSpan timeSpan = finishDate - startDate;
            return (uint)timeSpan.TotalMinutes;
        }

        public bool IsArrivingToday()
        {
            return StartDate.getYear() == FinishDate.getYear() &&
                   StartDate.getMonth() == FinishDate.getMonth() &&
                   StartDate.getDay() == FinishDate.getDay();
        }


    }
}