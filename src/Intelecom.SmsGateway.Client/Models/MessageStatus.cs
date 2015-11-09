using Intelecom.SmsGateway.Client.Constants;

namespace Intelecom.SmsGateway.Client.Models
{
    /// <summary>
    /// Message status.
    /// </summary>
    public class MessageStatus
    {
        /// <summary>
        /// Status code.
        /// </summary>
        public SmsGatewayStatusCode StatusCode { get; set; }

        /// <summary>
        /// Textual information about status, e.g. which parameter failed.
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// The client reference ID if specified in the request.
        /// </summary>
        public string ClientReference { get; set; }

        /// <summary>
        /// The recipient. 
        /// NOTE: The gateway runs all numbers through a number parser so 
        /// the recipient in the response may not be in same format as in the request, 
        /// i.e. “+47 41 00 00 00” will be “+4741000000” in the response.
        /// Use the ClientReference if you need to match messages in the request and response.
        /// </summary>
        public string Recipient { get; set; }

        /// <summary>
        /// Message ID (used as reference for delivery reports).
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Session ID for a session. Only returned if NewSession parameter is set to true, or if you are specifying a session ID.
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// The messages in the response will always be in the same order as in the request. 
        /// The sequence index is a convenience counter starting at 1.
        /// </summary>
        public int SequenceIndex { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString() => $"StatusCode: {StatusCode}, StatusMessage: {StatusMessage}, ClientReference: {ClientReference}, " +
                                             $"Recipient: {Recipient}, MessageId: {MessageId}, SessionId: {SessionId}, SequenceIndex: {SequenceIndex}";
    }
}