using Intelecom.SmsGateway.Client.Converters;
using Newtonsoft.Json;
using System;

namespace Intelecom.SmsGateway.Client.Models
{
    /// <summary>
    /// Send window.
    /// </summary>
    public class SendWindow
    {
        /// <summary>
        /// The date to send the message.
        /// </summary>
        [JsonConverter(typeof(SmsGatewayDateTimeConverter), "yyyy-MM-dd")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The time of day to start sending the message.
        /// </summary>
        [JsonConverter(typeof(SmsGatewayDateTimeConverter), "HH:mm:ss")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The date to stop sending the message if the message is still enqueued.
        /// </summary>
        [JsonConverter(typeof(SmsGatewayDateTimeConverter), "yyyy-MM-dd")]
        public DateTime? StopDate { get; set; }

        /// <summary>
        /// The time to stop sending the message if the message is still enqueued.
        /// </summary>
        [JsonConverter(typeof(SmsGatewayDateTimeConverter), "HH:mm:ss")]
        public DateTime? StopTime { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString() => $"StartDate: {StartDate}, StartTime: {StartTime}, StopDate: {StopDate}, StopTime: {StopTime}";
    }
}