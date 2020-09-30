using System.Threading.Tasks;
using Abp.Application.Services;
using docspider.Authorization.Accounts.Dto;

namespace docspider.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
