using System.Threading.Tasks;
using GPDH.Evolution.Configuration.Dto;

namespace GPDH.Evolution.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
