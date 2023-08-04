using System;

namespace BasicFacebookFeatures
{
    internal class NoDataAvailableException : Exception
    {
        public NoDataAvailableException() : base("No data is available at the moment.")
        {
        }

        public NoDataAvailableException(string message) : base(message)
        {
        }

        public NoDataAvailableException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
