using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class Utillity
    {
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
