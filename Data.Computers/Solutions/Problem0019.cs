using System;

namespace Data.Computers.Solutions
{
    public class Problem0019 : IProblem
    {
        private readonly DateTime START_DATE = new DateTime(1901, 1, 1);
        private readonly DateTime END_DATE = new DateTime(2000, 12, 31);

        public Problem0019(DateTime startDate, DateTime endDate)
        {
            START_DATE = startDate;
            END_DATE = endDate;
        }

        public Problem0019()
        {

        }

        public long ComputeSolution()
        {
            return NumberOfSundaysOnTheFirstOfTheMonth(START_DATE, END_DATE);
        }

        private int NumberOfSundaysOnTheFirstOfTheMonth(DateTime startDate, DateTime endDate)
        {
            var numberOfSundays = 0;
            DateTime dateToCheck = GetFirstDayOfTheMonthAfterOrEqualToDate(startDate);
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

        private DateTime GetFirstDayOfTheMonthAfterOrEqualToDate(DateTime date)
        {
            if (date.Day == 1)
            {
                return date;
            }
            return GetFirstDayOfTheMonthAfterDate(date);
        }

        private DateTime GetFirstDayOfTheMonthAfterDate(DateTime date)
        {
            var startingMonthIsLastMonthOfYear = date.Month == 12;
            var monthAfterStartDate = startingMonthIsLastMonthOfYear ? 1 : date.Month + 1;
            var yearCorrespondingToNextMonth = startingMonthIsLastMonthOfYear ? date.Year + 1 : date.Year;
            return new DateTime(yearCorrespondingToNextMonth, monthAfterStartDate, 1);
        }
    }
}