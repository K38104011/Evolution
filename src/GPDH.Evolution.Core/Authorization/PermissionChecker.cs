using Abp.Authorization;
using GPDH.Evolution.Authorization.Roles;
using GPDH.Evolution.Authorization.Users;

namespace GPDH.Evolution.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
