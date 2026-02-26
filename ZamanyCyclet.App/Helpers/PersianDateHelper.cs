using System;
using System.Globalization;

namespace ZamanyCyclet.App.Helpers
{
    /// <summary>
    /// Provides Persian (Shamsi) date formatting and conversion utilities.
    /// </summary>
    public static class PersianDateHelper
    {
        private static readonly PersianCalendar _persianCalendar = new PersianCalendar();

        private static readonly string[] _monthNames =
        {
            "فروردین", "اردیبهشت", "خرداد",
            "تیر", "مرداد", "شهریور",
            "مهر", "آبان", "آذر",
            "دی", "بهمن", "اسفند"
        };

        #region Existing Methods (unchanged)

        public static string GetTodayLongDate()
        {
            return ToLongDate(DateTime.Now);
        }

        public static string ToLongDate(DateTime dateTime)
        {
            int year = _persianCalendar.GetYear(dateTime);
            int month = _persianCalendar.GetMonth(dateTime);
            int day = _persianCalendar.GetDayOfMonth(dateTime);

            string dayName = dateTime.ToString("dddd", new CultureInfo("fa-IR"));
            string monthName = _monthNames[month - 1];

            return $"امروز {dayName} {day} {monthName} ماه {year}";
        }

        #endregion

        #region Formatting

        /// <summary>
        /// Returns Persian date in short format (yyyy/MM/dd)
        /// </summary>
        public static string ToShortDate(DateTime dateTime)
        {
            int year = _persianCalendar.GetYear(dateTime);
            int month = _persianCalendar.GetMonth(dateTime);
            int day = _persianCalendar.GetDayOfMonth(dateTime);

            return $"{year:0000}/{month:00}/{day:00}";
        }

        /// <summary>
        /// Returns Persian date with time.
        /// </summary>
        public static string ToLongDateTime(DateTime dateTime)
        {
            return $"{ToShortDate(dateTime)} {dateTime:HH:mm:ss}";
        }

        /// <summary>
        /// Returns long Persian date without prefix text.
        /// </summary>
        public static string ToLongDateWithoutPrefix(DateTime dateTime)
        {
            int year = _persianCalendar.GetYear(dateTime);
            int month = _persianCalendar.GetMonth(dateTime);
            int day = _persianCalendar.GetDayOfMonth(dateTime);

            string dayName = dateTime.ToString("dddd", new CultureInfo("fa-IR"));
            string monthName = _monthNames[month - 1];

            return $"{dayName} {day} {monthName} {year}";
        }

        #endregion

        #region Conversion

        /// <summary>
        /// Converts Persian date to Gregorian DateTime.
        /// </summary>
        public static DateTime ToGregorian(int year, int month, int day)
        {
            return _persianCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);
        }

        /// <summary>
        /// Converts Persian date with time to Gregorian DateTime.
        /// </summary>
        public static DateTime ToGregorian(int year, int month, int day, int hour, int minute, int second)
        {
            return _persianCalendar.ToDateTime(year, month, day, hour, minute, second, 0);
        }

        #endregion

        #region Calendar Info

        public static bool IsLeapYear(int year)
        {
            return _persianCalendar.IsLeapYear(year);
        }

        public static int DaysInMonth(int year, int month)
        {
            return _persianCalendar.GetDaysInMonth(year, month);
        }

        public static DateTime FirstDayOfMonth(DateTime dateTime)
        {
            int year = _persianCalendar.GetYear(dateTime);
            int month = _persianCalendar.GetMonth(dateTime);

            return ToGregorian(year, month, 1);
        }

        public static DateTime LastDayOfMonth(DateTime dateTime)
        {
            int year = _persianCalendar.GetYear(dateTime);
            int month = _persianCalendar.GetMonth(dateTime);

            int days = DaysInMonth(year, month);

            return ToGregorian(year, month, days);
        }

        #endregion

        #region Manipulation

        public static DateTime AddDays(DateTime dateTime, int days)
        {
            return dateTime.AddDays(days);
        }

        public static DateTime AddMonths(DateTime dateTime, int months)
        {
            int year = _persianCalendar.GetYear(dateTime);
            int month = _persianCalendar.GetMonth(dateTime);
            int day = _persianCalendar.GetDayOfMonth(dateTime);

            month += months;

            while (month > 12)
            {
                month -= 12;
                year++;
            }

            while (month < 1)
            {
                month += 12;
                year--;
            }

            int maxDay = DaysInMonth(year, month);
            if (day > maxDay)
                day = maxDay;

            return ToGregorian(year, month, day);
        }

        #endregion
    }
}