using System;

namespace BasicFacebookFeatures
{
    internal class NoDataAvailableException : Exception
    {
        public NoDataAvailableException(string i_Item)
            : base(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, i_Item))
        {
        }
    }
}
