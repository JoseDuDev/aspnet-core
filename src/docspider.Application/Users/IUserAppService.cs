using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using docspider.Roles.Dto;
using docspider.Users.Dto;

namespace docspider.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
