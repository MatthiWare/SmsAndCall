using System.Threading.Tasks;

namespace SmsAndCallClient.Api
{
    public interface IResponse
    {
        string Status { get; set; }

        bool CanUpdate { get; }

        Task UpdateAsync();
    }
}
