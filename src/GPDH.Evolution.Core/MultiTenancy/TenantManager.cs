using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using GPDH.Evolution.Authorization.Users;
using GPDH.Evolution.Editions;

namespace GPDH.Evolution.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
