
namespace Intelecom.SmsGateway.Client.Models
{
    /// <summary>
    /// SMS message.
    /// </summary>
    public interface IMessage : IMessageWithMandatoryProperties
    {
        /// <summary>
        /// The cost for the recipient to receive the message. In lowest monetary unit.
        /// </summary>
        uint Price { get; }

        /// <summary>
        /// Arbitrary client reference ID that will be returned in the message response.
        /// </summary>
        string ClientReference { get; }

        /// <summary>
        /// For advanced message settings.
        /// </summary>
        Settings Settings { get; }
    }
}