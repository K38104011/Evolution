using System.Threading.Tasks;
using Abp.Application.Services;
using GPDH.Evolution.Authorization.Accounts.Dto;

namespace GPDH.Evolution.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
