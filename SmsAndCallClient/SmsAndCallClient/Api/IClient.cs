using System.Threading.Tasks;

namespace MatthiWare.SmsAndCallClient.Api
{
    public interface IClient
    {
        /// <summary>
        /// Indicates if the client is initialized or not
        /// use <see cref="Init"/> to initialize the client.
        /// </summary>
        bool IsInitialized { get; set; }

        /// <summary>
        /// Indicates if the client supports sending text messages
        /// </summary>
        bool CanSendSms { get; }

        /// <summary>
        /// Inidicates if the client supports calls
        /// </summary>
        bool CanCall { get; }

        /// <summary>
        /// Inidicates if the from number is required
        /// </summary>
        bool FromNumberRequired { get; }

        /// <summary>
        /// Initializes the client and marks the client as <see cref="IsInitialized"/> 
        /// </summary>
        void Init();

        /// <summary>
        /// Calls the number asynchronously
        /// </summary>
        /// <param name="from">The from number can be optional <see cref="FromNumberRequired"/> </param>
        /// <param name="to">The number to call</param>
        /// <param name="msg">What we want to say</param>
        /// <returns>The response</returns>
        Task<IResponse> CallAsync(string from, string to, string msg);

        /// <summary>
        /// Sends a text message asynchronously
        /// </summary>
        /// <param name="from">The from number can be optional <see cref="FromNumberRequired"/> </param>
        /// <param name="to">The number to text</param>
        /// <param name="msg">The message</param>
        /// <returns>The response</returns>
        Task<IResponse> SendSmsAsync(string form, string to, string msg);

        /// <summary>
        /// The client name
        /// </summary>
        string ToString();
    }
}
