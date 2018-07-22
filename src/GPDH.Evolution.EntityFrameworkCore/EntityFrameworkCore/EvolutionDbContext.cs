using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GPDH.Evolution.Authorization.Roles;
using GPDH.Evolution.Authorization.Users;
using GPDH.Evolution.MultiTenancy;
using GPDH.Evolution.Core.Tasks;

namespace GPDH.Evolution.EntityFrameworkCore
{
    public class EvolutionDbContext : AbpZeroDbContext<Tenant, Role, User, EvolutionDbContext>
    {
        public DbSet<Task> Tasks { get; set; }
        
        public EvolutionDbContext(DbContextOptions<EvolutionDbContext> options)
            : base(options)
        {
        }
    }
}
