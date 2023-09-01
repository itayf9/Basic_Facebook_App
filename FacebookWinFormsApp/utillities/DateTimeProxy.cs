using System;

namespace BasicFacebookFeatures.utillities
{
    public class DateTimeProxy
    {
        private DateTime r_DateTime;

        private int numberOfYearsFromDate;

        private DateTimeProxy(DateTime i_DateTime)
        {
            r_DateTime = i_DateTime;
            numberOfYearsFromDate = Utillity.CalculateAge(i_DateTime);
        }


        public static DateTimeProxy GetDateTimeObjectFromDateString(string i_DateAsString)
        {
            return new DateTimeProxy(
                DateTime.ParseExact(i_DateAsString, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture));
        }

        public override string ToString()
        {
            return string.Format("{0:dd/MM/yyyy} ({1} Years Old)", r_DateTime, numberOfYearsFromDate);
        }
    }
}