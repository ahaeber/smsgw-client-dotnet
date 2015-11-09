using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intelecom.SmsGateway.Client.Models
{
    /// <summary>
    /// Settings.
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// Uses service value unless specified. 
        /// Used to prioritize between messages sent from the same service. 
        /// 1: low (slower), 2: medium, 3: high(faster)
        /// </summary>
        public int? Priority { get; set; }

        /// <summary>
        /// Uses service value unless specified. 
        /// Specifies the TTL(time to live) for the message, 
        /// i.e.how long before the message times out in cases 
        /// where it cannot be delivered to a handset. 
        ///  </summary>
        public int? Validity { get; set; }

        /// <summary>
        /// Arbitrary string set by the client to enable grouping messages in certain statistic reports.
        /// </summary>
        public string Differentiator { get; set; }

        /// <summary>
        /// Only relevant for CPA/GAS messages. 
        /// Defines an age limit for message content.
        /// The mobile network operators enforces this. 
        /// IMPORTANT: If the service is a subscription service all CPA/GAS messages must have age set to 18. 
        /// Valid values: 0, 16 or 18.
        /// </summary>
        public int? Age { get; set; }

        /// <summary>
        /// Used to start a new session.
        /// </summary>
        public bool NewSession { get; set; }

        /// <summary>
        /// Used to continue an existing session.
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Arbitrary string set by the client to enable grouping messages on the service invoice.
        /// </summary>
        public string InvoiceNode { get; set; }

        /// <summary>
        /// Currently not in use.
        /// </summary>
        public bool AutoDetectEncoding { get; set; }

        /// <summary>
        /// If set to true the gateway will remove or safely substitute invalid characters in the message content instead of rejecting the message.
        /// </summary>
        public bool SafeRemoveNonGsmCharacters { get; set; }

        /// <summary>
        /// Uses service value unless specified. Used to specify the originator.
        /// </summary>
        public OriginatorSettings OriginatorSettings { get; set; }

        /// <summary>
        /// Uses service value unless specified. Used if the message is a CPA Goods and Services transaction.
        /// </summary>
        public GasSettings GasSettings { get; set; }

        /// <summary>
        /// Used if the message should be queued and sent in the future instead of immediately.
        /// </summary>
        public SendWindow SendWindow { get; set; }

        /// <summary>
        /// Used to specify special settings including settings for binary message.
        /// </summary>
        [JsonProperty("parameter")]
        public IEnumerable<Parameter> Parameters { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString() => $"Priority: {Priority}, Validity: {Validity}, Differentiator: {Differentiator}, Age: {Age}, " +
                                             $"NewSession: {NewSession}, SessionId: {SessionId}, InvoiceNode: {InvoiceNode}, " +
                                             $"AutoDetectEncoding: {AutoDetectEncoding}, SafeRemoveNonGsmCharacters: {SafeRemoveNonGsmCharacters}, " +
                                             $"OriginatorSettings: {OriginatorSettings}, GasSettings: {GasSettings}, SendWindow: {SendWindow}, Parameter: {Parameters}";
    }
}