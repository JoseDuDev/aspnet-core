using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace docspider.Controllers
{
    public abstract class docspiderControllerBase: AbpController
    {
        protected docspiderControllerBase()
        {
            LocalizationSourceName = docspiderConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
