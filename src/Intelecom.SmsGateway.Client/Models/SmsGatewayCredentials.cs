using System;

namespace Intelecom.SmsGateway.Client.Models
{
    /// <summary>
    /// Gateway credentials.
    /// </summary>
    public class SmsGatewayCredentials
    {
        /// <summary>
        /// Identifies the service. Provided by Intelecom service desk.
        /// </summary>
        public uint ServiceId { get; }

        /// <summary>
        /// For authentication. Provided by Intelecom service desk.
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// For authentication. Provided by Intelecom service desk.
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="SmsGatewayCredentials"/>.
        /// </summary>
        /// <param name="serviceId">Service ID.</param>
        /// <param name="username">Service username.</param>
        /// <param name="password">Service password.</param>
        /// <exception cref="ArgumentException">If any of the parameters are invalid.</exception>
        public SmsGatewayCredentials(uint serviceId, string username, string password)
        {
            if (serviceId == 0) throw new ArgumentException("Invalid Service ID.");
            if (string.IsNullOrEmpty(username)) throw new ArgumentException(nameof(username));
            if (string.IsNullOrEmpty(password)) throw new ArgumentException(nameof(password));
            ServiceId = serviceId;
            Username = username;
            Password = password;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString() => $"ServiceId: {ServiceId}, Username: {Username}, Password: {Password}";
    }
}