using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GPDH.Evolution.Roles.Dto;
using GPDH.Evolution.Users.Dto;

namespace GPDH.Evolution.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
