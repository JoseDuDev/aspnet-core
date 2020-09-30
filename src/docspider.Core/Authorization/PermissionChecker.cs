using Abp.Authorization;
using docspider.Authorization.Roles;
using docspider.Authorization.Users;

namespace docspider.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
