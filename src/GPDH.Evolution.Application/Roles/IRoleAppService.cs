using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GPDH.Evolution.Roles.Dto;

namespace GPDH.Evolution.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
