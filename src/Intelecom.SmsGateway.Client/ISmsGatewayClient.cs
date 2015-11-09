using Intelecom.SmsGateway.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Intelecom.SmsGateway.Client
{
    /// <summary>
    /// SMS Gateway client.
    /// </summary>
    public interface ISmsGatewayClient
    {
        /// <summary>
        /// Sends a message to the gateway.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <returns>Gateway response.</returns>
        Task<SmsGatewayResponse> SendAsync(IMessageWithMandatoryProperties message);

        /// <summary>
        /// Send one or more messages to the gateway.
        /// </summary>
        /// <param name="messages">The message(s) to send.</param>
        /// <returns>Gateway response.</returns>
        Task<SmsGatewayResponse> SendAsync(IEnumerable<IMessageWithMandatoryProperties> messages);
    }
}