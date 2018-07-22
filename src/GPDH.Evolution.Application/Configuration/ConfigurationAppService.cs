using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GPDH.Evolution.Configuration.Dto;

namespace GPDH.Evolution.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EvolutionAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
