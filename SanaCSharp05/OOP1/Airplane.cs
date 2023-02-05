using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP1;

namespace OOP1
{
    public class Airplane
    {
        protected string sCity;
        public string startCity
        {
            set
            {
                if (value != "") sCity = value;
            }
            get { 
                return sCity; 
            }
        }
        protected string eCity;
        public string endCity
        {
            set
            {
                if (value != "") eCity = value;
            }
            get { 
                return eCity; 
            }
        }
        protected Date StartDate;
        public Date startDate
        {
            set
            {
                StartDate = new Date(value);
            }
            get { return StartDate; }
        }
        protected Date EndDate;
        public Date endDate
        {
            set
            {
                EndDate = new Date(value);
            }
            get
            {
                return EndDate;
            }
        }
        public Airplane()
        {
            startCity = "Zhytomyr";
            endCity = "Korosten'";
            startDate = new Date(2020, 08, 15, 11, 15);
            endDate = new Date(2020, 08, 17, 09, 48);
        }
        public Airplane(string sCity, string eCity, Date startDate, Date endDate) { 
            startCity = sCity;
            endCity = eCity;
            startDate = new Date();
            endDate = new Date();
        }
        public Airplane(Airplane obj)
        {
            startCity = obj.startCity;
            endCity = obj.endCity;
            startDate = new Date(obj.startDate);
            endDate = new Date(obj.endDate);
        }
        public int GetTotalTime(Airplane obj)
        {
            int difftimeMinute, difftimeHour, difftimeDay, difftimeMonth, difftimeYear;
            difftimeMinute = obj.startDate.timeMinute < obj.endDate.timeMinute ? obj.endDate.timeMinute - obj.startDate.timeMinute : 0;
            difftimeHour = obj.startDate.timeHour < obj.endDate.timeHour ? (obj.endDate.timeHour - obj.startDate.timeHour) * 60 : 0;
            difftimeDay = obj.startDate.timeDay < obj.endDate.timeDay ? (obj.endDate.timeDay - obj.startDate.timeDay) * 60 * 24 : 0;
            difftimeMonth = obj.startDate.timeMonth < obj.endDate.timeMonth ? (obj.endDate.timeMonth - obj.startDate.timeMonth) * 60 * 24 * 30 : 0;
            difftimeYear = obj.startDate.timeYear < obj.endDate.timeYear ? (obj.endDate.timeYear - obj.startDate.timeYear) * 60 * 24 * 30 * 365 : 0;
            return difftimeMinute + difftimeHour + difftimeDay + difftimeMonth + difftimeYear;
        }
        public bool IsArrivingToday(Airplane obj)
        {
            if (obj.startDate != null && obj.endDate != null)
            {
                if (obj.startDate.timeYear == obj.endDate.timeYear && obj.startDate.timeMonth == obj.endDate.timeMonth && obj.startDate.timeDay == obj.endDate.timeDay)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
    }
}
