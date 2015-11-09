using Intelecom.SmsGateway.Client.Exceptions;
using Intelecom.SmsGateway.Client.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Intelecom.SmsGateway.Client
{
    /// <summary>
    /// SMS Gateway client.
    /// </summary>
    public class SmsGatewayClient : ISmsGatewayClient
    {
        private const string RelativeUri = "sendMessages";
        private readonly SmsGatewayCredentials _credentials;
        private HttpClient _httpClient;
        private readonly JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        /// <summary>
        /// Initializes a new instance of <see cref="SmsGatewayClient"/>.
        /// </summary>
        /// <param name="baseAddress">Base address.</param>
        /// <param name="credentials">Service credentials.</param>
        public SmsGatewayClient(string baseAddress, SmsGatewayCredentials credentials)
            : this(baseAddress, credentials, new HttpClientHandler())
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="SmsGatewayClient"/>.
        /// </summary>
        /// <param name="baseAddress">Base address.</param>
        /// <param name="credentials">Service credentials.</param>
        /// <param name="messageHandler">Message handler.</param>
        /// <exception cref="ArgumentNullException">If any of the parameters are null.</exception>
        public SmsGatewayClient(string baseAddress, SmsGatewayCredentials credentials, HttpMessageHandler messageHandler)
        {
            if (baseAddress == null) throw new ArgumentNullException(nameof(baseAddress));
            if (credentials == null) throw new ArgumentNullException(nameof(credentials));
            if (messageHandler == null) throw new ArgumentNullException(nameof(messageHandler));
            _credentials = credentials;
            CreateHttpClient(baseAddress, messageHandler);
        }

        /// <summary>
        /// Creates and configures the inner <see cref="HttpClient"/>.
        /// </summary>
        /// <param name="baseAddress">Gateway base address.</param>
        /// <param name="messageHandler">Message handler.</param>
        protected void CreateHttpClient(string baseAddress, HttpMessageHandler messageHandler)
        {
            _httpClient = new HttpClient(messageHandler) { BaseAddress = new Uri(baseAddress) };
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Sends a message to the gateway.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <returns>Gateway response.</returns>
        public Task<SmsGatewayResponse> SendAsync(IMessageWithMandatoryProperties message)
        {
            return SendAsync(new[] { message });
        }

        /// <summary>
        /// Send one or more messages to the gateway.
        /// </summary>
        /// <param name="messages">The message(s) to send.</param>
        /// <returns>Gateway response.</returns>
        public async Task<SmsGatewayResponse> SendAsync(IEnumerable<IMessageWithMandatoryProperties> messages)
        {
            var request = new SmsGatewayRequest
            {
                ServiceId = _credentials.ServiceId,
                Username = _credentials.Username,
                Password = _credentials.Password,
                Messages = messages
            };
            var content = new StringContent(JsonConvert.SerializeObject(request, _jsonSerializerSettings), Encoding.UTF8, "application/json");
            var responseMessage = await _httpClient.PostAsync(RelativeUri, content).ConfigureAwait(false);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new SmsGatewayException($"Gateway error: {responseMessage.StatusCode} - {responseMessage.ReasonPhrase}");
            }
            var response = JsonConvert.DeserializeObject<SmsGatewayResponse>(await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false));

            return response;
        }
    }
}