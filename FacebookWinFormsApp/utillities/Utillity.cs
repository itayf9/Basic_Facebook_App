using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.utillities
{
    internal static class Utillity
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
