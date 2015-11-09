using Intelecom.SmsGateway.Client.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Intelecom.SmsGateway.Client.Tests.Helpers
{
    public class FakeSmsGatewayResponseGenerator : HttpMessageHandler
    {
        private readonly Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> _requestHandler;

        public FakeSmsGatewayResponseGenerator(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> requestHandler)
        {
            _requestHandler = requestHandler;
        }

        public static HttpResponseMessage GenerateResponseMessage(MessageStatus messageStatus)
        {
            var gatewayResponse = new SmsGatewayResponse { MessageStatus = new[] { messageStatus } };
            var responseMessage = new HttpResponseMessage { Content = new StringContent(JsonConvert.SerializeObject(gatewayResponse)) };

            return responseMessage;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return _requestHandler(request, cancellationToken);
        }
    }
}