namespace DayNameInBulgarianService
{
    using System;

    public class DayNameInBulgarianService : IDayNameInBulgarianService
    {
        public string GetDayOfWeekInBulgarian(DateTime dateTime)
        {
            var culture = new System.Globalization.CultureInfo("bg-BG");
            string day = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);
            return day;
        }
    }
}