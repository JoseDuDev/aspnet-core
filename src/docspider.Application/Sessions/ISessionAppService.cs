using System.Threading.Tasks;
using Abp.Application.Services;
using docspider.Sessions.Dto;

namespace docspider.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
