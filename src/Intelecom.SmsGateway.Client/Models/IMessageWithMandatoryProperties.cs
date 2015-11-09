namespace Intelecom.SmsGateway.Client.Models
{
    /// <summary>
    /// SMS message with mandatory properties.
    /// </summary>
    public interface IMessageWithMandatoryProperties
    {
        /// <summary>
        /// The MSISDN of the recipient. The format should follow the ITUT E.164 standard with a + prefix.
        /// </summary>
        string Recipient { get; }

        /// <summary>
        /// The message payload to send, typically the message text.
        /// </summary>
        string Content { get; }
    }
}