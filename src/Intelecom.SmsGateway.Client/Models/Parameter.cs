namespace Intelecom.SmsGateway.Client.Models
{
    /// <summary>
    /// Parameter.
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Key. Example: dcs
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Value. Example: F5
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString() => $"Key: {Key}, Value: {Value}";
    }
}