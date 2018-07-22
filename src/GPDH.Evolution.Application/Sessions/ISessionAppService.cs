using System.Threading.Tasks;
using Abp.Application.Services;
using GPDH.Evolution.Sessions.Dto;

namespace GPDH.Evolution.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
