using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal static class Utillity
    {
        public static DateTime GetDateTimeObjectFromDateString(string i_DateAsString)
        {
            return DateTime.ParseExact(
                i_DateAsString,
                "MM/dd/yyyy",
                System.Globalization.CultureInfo.InvariantCulture);
        }

        public static string CalculateAge(DateTime i_BirthdayDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - i_BirthdayDate.Year;

            if (i_BirthdayDate > today.AddYears(-age))
            {
                age--;
            }

            return age.ToString();
        }
    }
}
