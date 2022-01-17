using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.NewFeatures.CSharp10
{
    public class DateTime2
    {
        public DateTime2(DateTime now)
        {
            Year = now.Year;
            Month = now.Month;
            Day = now.Day;
        }

        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public DateTimeType Type { get; set; }
        public static bool IsToday(DateTime2 date) => date is { Year: 2022, Month: 1, Day: 14 };
        public override string ToString() => $"Year:{Year}, Month:{Month}, Day:{Day}, Type:{Type}";
    }

    public class DateTimeType
    {
        public bool IsNull { get; set; }
    }
}
