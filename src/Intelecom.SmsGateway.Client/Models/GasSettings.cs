namespace Intelecom.SmsGateway.Client.Models
{
    /// <summary>
    /// Goods and services settings.
    /// </summary>
    public class GasSettings
    {
        /// <summary>
        /// Identifier for the category of Goods and services.
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// Further details of the Goods and services.
        /// The description may occur on the end-user invoice(together with category) for certain Mobile Network Operators.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString() => $"ServiceCode: {ServiceCode}, Description: {Description}";
    }
}