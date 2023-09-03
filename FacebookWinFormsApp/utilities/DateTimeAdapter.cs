using System;
using System.Globalization;

namespace BasicFacebookFeatures.utilities
{
    public class DateTimeAdapter : IDateFormatAgeCalculator
    {
        private DateTime m_DateTime;

        public void SetDateFromDateString(string i_FacebookApiUserBirthdayDateFormat)
        {
            m_DateTime = DateTime.ParseExact(i_FacebookApiUserBirthdayDateFormat, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            int age = Utility.CalculateAge(m_DateTime);
            return $"{m_DateTime:dd/MM/yyyy} ({age} Years Old)";
        }
    }
}