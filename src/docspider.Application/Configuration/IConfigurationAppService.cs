using System.Threading.Tasks;
using docspider.Configuration.Dto;

namespace docspider.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
