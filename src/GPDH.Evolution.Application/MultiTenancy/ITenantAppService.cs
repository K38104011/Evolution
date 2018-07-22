using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GPDH.Evolution.MultiTenancy.Dto;

namespace GPDH.Evolution.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
