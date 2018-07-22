using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GPDH.Evolution.Controllers
{
    public abstract class EvolutionControllerBase: AbpController
    {
        protected EvolutionControllerBase()
        {
            LocalizationSourceName = EvolutionConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
