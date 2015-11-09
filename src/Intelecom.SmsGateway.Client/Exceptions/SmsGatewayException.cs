using System;

namespace Intelecom.SmsGateway.Client.Exceptions
{
    /// <summary>
    /// Gateway exception.
    /// </summary>
    public class SmsGatewayException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsGatewayException"/> with an error message.
        /// </summary>
        /// <param name="message">Error message.</param>
        public SmsGatewayException(string message)
            : base(message)
        {
        }
    }
}