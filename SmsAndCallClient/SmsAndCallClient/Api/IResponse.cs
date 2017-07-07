using System.Threading.Tasks;

namespace MatthiWare.SmsAndCallClient.Api
{
    public interface IResponse
    {
        string Status { get; set; }

        bool CanUpdate { get; }

        Task UpdateAsync();
    }
}
