
using System.Linq;

namespace Intelecom.SmsGateway.Client.Models
{
    /// <summary>
    /// Gateway response.
    /// </summary>
    public class SmsGatewayResponse
    {
        /// <summary>
        /// A unique system generated reference to the batch
        /// </summary>
        public string BatchReference { get; set; }

        /// <summary>
        /// The status of each message sent to the gateway.
        /// </summary>
        public MessageStatus[] MessageStatus { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString() => $"BatchReferece: {BatchReference}. MessageStatus: {string.Join(" | ", MessageStatus.Select(status => status))}";
    }
}