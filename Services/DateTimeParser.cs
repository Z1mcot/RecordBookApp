using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordBookApp.Services
{
    public static class DateTimeParser
    {
        static readonly string[] dateTimeFormats = { "dd.MM.yyyy", "G" };

        public static bool TryParse(
            string s,
            out DateTime result,
            DateTimeStyles style = DateTimeStyles.None)
        {
            return DateTime.TryParseExact(s, dateTimeFormats, CultureInfo.GetCultureInfo("ru-RU"), style, out result);
        }

        public static string ToStringWithFormat(DateTime dt, string format = "G")
        {
            return dt.ToString(format, CultureInfo.GetCultureInfo("ru-RU"));
        }
    }
}
