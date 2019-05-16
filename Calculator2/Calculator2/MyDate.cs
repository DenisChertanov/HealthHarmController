using System;
using System.Collections.Generic;
using System.Text;
using Realms;

namespace Calculator2
{
    public class MyDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return Day + "." + Month + "." + Year + " " + Hour + "." + Minute + "." + Second + " " + Type;
        }

        public MyDate(string s)
        {
            string[] str = s.Split(' ');
            string[] Date = str[0].Split(new Char[] { '.', '/', ':' });
            string[] Time = str[1].Split(new Char[] { '.', '/', ':' });

            Day = Int32.Parse(Date[0]);
            Month = Int32.Parse(Date[1]);            
            Year = Int32.Parse(Date[2]);

            Hour = Int32.Parse(Time[0]);
            Minute = Int32.Parse(Time[1]);
            Second = Int32.Parse(Time[2]);
        }

        public MyDate(DateTime Date)
        {
            Day = Date.Day;
            Month = Date.Month;
            Year = Date.Year;

            Hour = Date.Hour;
            Minute = Date.Minute;
            Second = Date.Second;
        }

        public MyDate()
        {
        }

        public static long DateToLong (MyDate a)
        {
            DateTime dateTime = new DateTime(a.Year, a.Month, a.Day);

            long ans = 0;

            // Посчитаем сколько секунд прошло с 1960 года по текущий год
            for (int i = 1960; i < a.Year; ++i)
            {
                if (DateTime.IsLeapYear(i))
                    ans += 366 * 24 * 60 * 60;
                else
                    ans += 365 * 24 * 60 * 60;
            }

            ans += (dateTime.DayOfYear - 1) * 24 * 60 * 60;

            for (int i = 1; i <= 24; ++i)
            {
                if (i <= a.Hour)
                    ans += 60 * 60;
            }

            for (int i = 1; i < 60; ++i)
            {
                if (i <= a.Minute)
                    ans += 60;
            }

            ans += a.Second;

            return ans;
        }

        public static string TimeToString(long val, int type)
        {            
            long seconds = 0, hours = 0, minutes = 0, days = 0;

            if (type == 1 || type == 2)
            {
                if (val > 365 * 24 * 60 * 60)
                {
                    if (type == 1)
                        return "Вы не курили больше года!";
                    else
                        return "Вы не пили больше года!";
                }
            }

            if (val / (60 * 60 * 24) > 0) {
                days = val / (60 * 60 * 24);
                val -= days * 60 * 60 * 24;                
            }

            if (val / (60 * 60) > 0)
            {
                hours = val / (60 * 60);
                val -= hours * 60 * 60;                
            }

            if (val / (60) > 0)
            {
                minutes = val / (60);
                val -= minutes * 60;                
            }

            if (val > 0)
            {                
                seconds = val;
            }

            string StrType = "";
            if (type == 1)
                StrType = "сигареты:";
            if (type == 2)
                StrType = "кружки:";
            if (type == 3)
                StrType = "сигаретами:";
            if (type == 4)
                StrType = "кружками:";
            if (type == 5)
                StrType = "сигареты";
            if (type == 6)
                StrType = "кружки";

            if (type == 1 || type == 2)
            {
                return $"С последней {StrType}\n {days}д {hours}ч {minutes}м {seconds}с!";
            }
            if (type == 3 || type == 4)
            {
                return $"Среднее время между {StrType} {days}д {hours}ч {minutes}м {seconds}с!";
            }
            if (type == 5 || type == 6)
            {
                return $"С первой {StrType} прошло:\n {days}д {hours}ч {minutes}м {seconds}с!";
            }
            if (type == 7)
            {
                return $"Максимальный промежуток воздержания: {days}д {hours}ч {minutes}м {seconds}с!";
            }
            if (type == 8)
            {
                return $"Длительность курения последней сигареты: {days}д {hours}ч {minutes}м {seconds}с!";
            }
            if (type == 9)
            {
                return $"Длительность последнего принятия алкоголя: {days}д {hours}ч {minutes}м {seconds}с!";
            }

            return "";
        }
    }
}
