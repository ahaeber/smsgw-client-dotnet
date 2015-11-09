using Newtonsoft.Json.Converters;

namespace Intelecom.SmsGateway.Client.Converters
{
    internal class SmsGatewayDateTimeConverter : IsoDateTimeConverter
    {
        public SmsGatewayDateTimeConverter(string dateTimeFormat)
        {
            DateTimeFormat = dateTimeFormat;
        }
    }
}