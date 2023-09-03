using System;

namespace BasicFacebookFeatures.utilities
{
    internal static class Utility
    {
        public static int CalculateAge(DateTime i_BirthdayDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - i_BirthdayDate.Year;

            if (i_BirthdayDate > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
