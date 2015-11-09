namespace Intelecom.SmsGateway.Client.Models
{
    /// <summary>
    /// SMS message.
    /// </summary>
    public class Message : IMessage
    {
        /// <summary>
        /// The MSISDN of the recipient. The format should follow the ITUT E.164 standard with a + prefix.
        /// </summary>
        public string Recipient { get; set; }

        /// <summary>
        /// The message payload to send, typically the message text.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// The cost for the recipient to receive the message. In lowest monetary unit.
        /// </summary>
        public uint Price { get; set; }

        /// <summary>
        /// For advanced message settings.
        /// </summary>
        public Settings Settings { get; set; }

        /// <summary>
        /// Arbitrary client reference ID that will be returned in the message response.
        /// </summary>
        public string ClientReference { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString() => $"Recipient: {Recipient}, Content: {Content}, Price: {Price}, Settings: {Settings}, ClientReference: {ClientReference}";
    }
}