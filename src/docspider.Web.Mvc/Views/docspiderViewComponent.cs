using Abp.AspNetCore.Mvc.ViewComponents;

namespace docspider.Web.Views
{
    public abstract class docspiderViewComponent : AbpViewComponent
    {
        protected docspiderViewComponent()
        {
            LocalizationSourceName = docspiderConsts.LocalizationSourceName;
        }
    }
}
