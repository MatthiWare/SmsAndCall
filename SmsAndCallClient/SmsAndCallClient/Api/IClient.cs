using System.Threading.Tasks;

namespace SmsAndCallClient.Api
{
    public interface IClient
    {
        bool IsInitialized { get; set; }

        bool CanSendSms { get; }

        bool CanCall { get; }

        bool FromNumberRequired { get; }

        void Init();

        Task<IResponse> CallAsync(string from, string to, string msg);

        Task<IResponse> SendSmsAsync(string form, string to, string msg);

        string ToString();
    }
}
