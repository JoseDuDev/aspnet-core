using System.Collections.Generic;
using docspider.Roles.Dto;
using docspider.Users.Dto;

namespace docspider.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
