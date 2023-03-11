using System;

namespace OOP1
{
    public class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;
        public double GetTimeInMinutes()
        {
            double res = Year * 365 * 24 * 60;
            res += Month * 365 / 12 * 24 * 60;
            res += Day * 24 * 60;
            res += Hours * 60;
            res += Minutes;
            return res;
        }
        public Date(int[] arr, int i = 0)
        {
            Year = arr[i];
            Month = arr[++i];
            Day = arr[++i];
            Hours = arr[++i];
            Minutes = arr[++i];
        }
        public Date()
        {
            Year = 2021;
            Month = 12;
            Day = 12;
            Hours = 12;
            Minutes = 21;
        }
        public Date(Date obj)
        {
            this.Year = obj.Year;
            this.Month = obj.Month;
            this.Day = obj.Day;
            this.Hours = obj.Hours;
            this.Minutes = obj.Minutes;
        }
        public Date(int paryear, int parmonth, int parday, int parhours)
        {
            Year = paryear;
            Month = parmonth;
            Day = parday;
            Hours = parhours;
        }
        public Date(int paryear, int parmonth, int parday, int parhours, int parminutes)
        {
            Year = paryear;
            Month = parmonth;
            Day = parday;
            Hours = parhours;
            Minutes = parminutes;
        }
        public int GetYear
        {
            set
            {
                Year = value;
            }
            get
            {
                return Year;
            }
        }
        public int GetMonth
        {
            set
            {
                Month = value;
            }
            get
            {
                return Month;
            }
        }
        public int GetDay
        {
            set
            {
                Day = value;
            }
            get
            {
                return Day;
            }
        }
        public int GetHours
        {
            set
            {
                Hours = value;
            }
            get
            {
                return Hours;
            }
        }
        public int GetMinutes
        {
            set
            {
                Minutes = value;
            }
            get
            {
                return Minutes;
            }
        }
    }
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;
        public Airplane()
        {
            StartCity = "Житомир";
            FinishCity = "Київ";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(Date startDate, Date finishDate)
        {
            StartCity = "Житомир";
            FinishCity = "Львів";
            StartDate = startDate;
            FinishDate = finishDate;
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
        public string startCity
        {
            set
            {
                StartCity = value;
            }
            get
            {
                return StartCity;
            }
        }
        public string finishCity
        {
            set
            {
                FinishCity = value;
            }
            get
            {
                return FinishCity;
            }
        }
        public Date GetStartDate
        {
            set
            {
                StartDate = value;
            }
            get
            {
                return StartDate;
            }
        }
        public Date GetFinishDate
        {
            set
            {
                FinishDate = value;
            }
            get
            {
                return FinishDate;
            }
        }
        public bool IsArrivingToday()
        {
            return GetStartDate.GetDay == GetFinishDate.GetDay;
        }
        public double GetTotalTime()
        {
            double result = (FinishDate.GetYear - StartDate.GetYear) * 365 * 24 * 60;
            result += (FinishDate.GetMonth - StartDate.GetMonth) * 365 / 12 * 24 * 60;
            result += (FinishDate.GetDay - StartDate.GetDay) * 24 * 60;
            result += (FinishDate.GetHours - StartDate.GetHours) * 60;
            result += FinishDate.GetMinutes - StartDate.GetMinutes;
            return result;
        }
        public Airplane(string start, string finish, params int[] arr)
        {
            StartCity = start;
            FinishCity = finish;
            StartDate = new Date(arr);
            FinishDate = new Date(arr, 5);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Airplane[] list = null;
            int ch;
            do
            {
                Console.WriteLine("\nНатисніть будь-яку кнопку\n");
                Console.ReadKey();
                Console.Clear();
                ShowMenu();
                ch = GetValue();
                switch (ch)
                {
                    case 1:
                        list = ReadAirplaneArray();
                        break;
                    case 2:
                        if (list == null)
                        {
                            Console.WriteLine("Спершу додайте рейс");
                            break;
                        }
                        PrintAirplanes(list);
                        break;
                    case 3:
                        if (list == null)
                        {
                            Console.WriteLine("Спершу додайте рейс");
                            break;
                        }
                        Console.WriteLine($"Введіть номер рейсу(1 ; {list.Length})");
                        int num = GetValue() - 1;
                        PrintAirplane(list[num]);
                        break;
                    case 4:
                        list = SortAirplanesByDate(list);
                        PrintAirplanes(list);
                        break;
                    case 5:
                        list = SortAirplanesByTotalTime(list);
                        PrintAirplanes(list);
                        break;
                    case 6:
                        int iMin, iMax;
                        GetAirplaneInfo(list, out iMax, out iMin);
                        break;
                    default:
                        Console.WriteLine("Не вірні номери, спробуйте ще раз!");
                        break;
                }
            } while (true);
        }
        static void ShowMenu()
        {
            Console.WriteLine("1 - Cтворити рейс/рейси\n" +
            "2 - Вивести всі рейси\n" +
            "3 - Вивести рейс\n" +
            "4 - Сортування за датою\n" +
            "5 - Сортування за часом подорожі\n" +
            "6 - Найбільший та найменший час подорожі\n");
        }
        readonly static string[] FieldNames ={
"місто відправлення",
 "місто прибуття",
 "рік відправлення",
 "місяць відправлення",
 "день відправлення",
 "година відправлення",
 "хвилини відправлення",
 "рік прибуття",
 "місяць прибуття",
 "день прибуття",
 "година прибуття",
 "хвилини прибуття",
 };
        static int GetValue()
        {
            int n;
            bool isRight = false;
            do
            {
                isRight = int.TryParse(Console.ReadLine(), out n);
                if (n <= 0)
                    isRight = false;
            } while (!isRight);
            return n;
        }
        static Airplane[] ReadAirplaneArray()
        {
            Console.WriteLine("Введіть кількість рейсів: ");
            int n = GetValue();
            string start, finish;
            int[] arg = new int[10];
            Airplane[] arr = new Airplane[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введіть {0}:", FieldNames[0]);
                start = Console.ReadLine();
                Console.WriteLine("Введіть {0}:", FieldNames[1]);
                finish = Console.ReadLine();
                for (int j = 0; j < arg.Length; j++)
                {
                    Console.WriteLine("Введіть {0}:", FieldNames[j + 2]);
                    arg[j] = GetValue();
                }
                arr[i] = new Airplane(start, finish, arg);
            }
            return arr;
        }
        static void PrintAirplane(Airplane elem)
        {
            Console.WriteLine($"Місто відправлення: {elem.startCity}\nМісто прибуття: {elem.finishCity}\n" +
        $"Рік відправлення: {elem.GetStartDate.GetYear}\nМісяць відправлення: {elem.GetStartDate.GetMonth}\n" +
        $"День відправлення: {elem.GetStartDate.GetDay}\nГодина відправлення: {elem.GetStartDate.GetHours}\n" +
        $"Хвилини відправлення: {elem.GetStartDate.GetMinutes}\nРік прибуття: {elem.GetFinishDate.GetYear}\n" +
        $"Місяць прибуття: {elem.GetFinishDate.GetMonth}\nДень прибуття: {elem.GetFinishDate.GetDay}\n" +
        $"Година прибуття: {elem.GetFinishDate.GetHours}\nХвилини прибуття: {elem.GetFinishDate.GetMinutes}\n");
        }
        static void PrintAirplanes(Airplane[] elems)
        {
            for (int i = 0; i < elems.Length; i++)
            {
                Console.WriteLine($"-----Рейс{i + 1}-----\n");
                PrintAirplane(elems[i]);
            }
        }
        static void GetAirplaneInfo(Airplane[] elems, out int iMaxOut, out int iMinOut)
        {
            double min = double.MinValue, max = double.MaxValue;
            int iMin = 0, iMax = 0;
            for (int i = 0; i < elems.Length; i++)
            {
                double temp = elems[i].GetTotalTime();
                if (temp > max)
                {
                    max = temp;
                    iMax = i;
                }
                else if (temp < min)
                {
                    min = temp;
                    iMin = i;
                }
            }
            iMaxOut = iMax;
            iMinOut = iMin;
            Console.WriteLine($"Максимальный час: {max}\n");
            PrintAirplane(elems[iMax]);
            Console.WriteLine($"Мінімальний час: {min}\n");
            PrintAirplane(elems[iMin]);
        }
        static int CompByDate(Airplane a, Airplane b)
        {
            double dateA = a.GetStartDate.GetTimeInMinutes();
            double dateB = b.GetStartDate.GetTimeInMinutes();
            if (dateA > dateB)
                return 1;
            else if (dateA < dateB)
                return -1;
            else
                return 0;
        }
        static int CompByTime(Airplane a, Airplane b)
        {
            double dateA = a.GetTotalTime(), dateB = b.GetTotalTime();
            if (dateA > dateB)
                return 1;
            else if (dateA < dateB)
                return -1;
            else
                return 0;
        }
        static Airplane[] SortAirplanesByDate(Airplane[] elems)
        {
            Array.Sort(elems, CompByDate);
            return elems;
        }
        static Airplane[] SortAirplanesByTotalTime(Airplane[] elems)
        {
            Array.Sort(elems, CompByTime);
            return elems;
        }
    }
}