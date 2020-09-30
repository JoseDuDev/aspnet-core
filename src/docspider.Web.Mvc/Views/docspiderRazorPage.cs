using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace docspider.Web.Views
{
    public abstract class docspiderRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected docspiderRazorPage()
        {
            LocalizationSourceName = docspiderConsts.LocalizationSourceName;
        }
    }
}
