using System;

namespace Data.Computers
{
    public static class DateHelper
    {
        public static int NumberOfSundaysOnTheFirstOfTheMonth(DateTime startDate, DateTime endDate)
        {
            var numberOfSundays = 0;
            var startingMonthIsLastMonthOfYear = startDate.Month == 12;
            var monthAfterStartDate = startingMonthIsLastMonthOfYear ? 1 : startDate.Month + 1;
            var yearCorrespondingToNextMonth = startingMonthIsLastMonthOfYear ? startDate.Year + 1 : startDate.Year;
            var firstDayOfTheNextMonthAfterStartDate = new DateTime(yearCorrespondingToNextMonth, monthAfterStartDate, 1);

            var dateToCheck = firstDayOfTheNextMonthAfterStartDate;

            while (dateToCheck < endDate)
            {
                if (dateToCheck.DayOfWeek == DayOfWeek.Sunday)
                {
                    numberOfSundays++;
                }

                dateToCheck = dateToCheck.AddMonths(1);
            }

            return numberOfSundays;
        }
    }
}
