using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Intelecom.SmsGateway.Client.Models
{
    /// <summary>
    /// Gateway request.
    /// </summary>
    internal class SmsGatewayRequest
    {
        /// <summary>
        /// Identifies the service. Provided by Intelecom service desk.
        /// </summary>
        public uint ServiceId { get; set; }

        /// <summary>
        /// For authentication. Provided by Intelecom service desk.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// For authentication. Provided by Intelecom service desk.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Reference ID that will be returned in the response.
        /// </summary>
        public string BatchReference { get; set; }

        /// <summary>
        /// The message(s) that will be sent to the gateway.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public IEnumerable<IMessageWithMandatoryProperties> Messages { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString() => $"ServiceId: {ServiceId}, Username: {Username}, Password: {Password}, " +
                                             $"BatchReference: {BatchReference}, Message: {string.Join(" | ", Messages.Select(message => message))}";
    }
}