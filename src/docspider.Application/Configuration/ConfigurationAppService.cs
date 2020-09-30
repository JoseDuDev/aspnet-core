using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using docspider.Configuration.Dto;

namespace docspider.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : docspiderAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
