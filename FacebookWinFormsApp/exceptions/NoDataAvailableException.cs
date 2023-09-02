using System;
using BasicFacebookFeatures.utilities;

namespace BasicFacebookFeatures.exceptions
{
    internal class NoDataAvailableException : Exception
    {
        public NoDataAvailableException(string i_CategoryName)
            : base(string.Format(Messages.k_NoItemsToRetreiveMessage, i_CategoryName))
        {
        }
    }
}
