namespace Intelecom.SmsGateway.Client.Models
{
    /// <summary>
    /// Originator settings.
    /// </summary>
    public class OriginatorSettings
    {
        /// <summary>
        /// Depends on the OriginatorType. Example: +4799999999, Intelecom, 1960.
        /// </summary>
        public string Originator { get; set; }

        /// <summary>
        /// Specifies the type of originator, one of <see cref="Constants.OriginatorType"/>.
        /// </summary>
        public string OriginatorType { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString() => $"Originator: {Originator}, OriginatorType: {OriginatorType}";
    }
}