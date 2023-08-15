using System;

namespace BasicFacebookFeatures
{
    internal class NoDataAvailableException : Exception
    {
        public NoDataAvailableException(string i_Item)
            : base(string.Format(Messages.k_NoItemsToRetreiveMessage, i_Item))
        {
        }
    }
}
