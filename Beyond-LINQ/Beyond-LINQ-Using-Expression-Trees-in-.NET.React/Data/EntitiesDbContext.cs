using System.Reflection;
using Beyond_LINQ_Using_Expression_Trees_in_.NET.React.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Beyond_LINQ_Using_Expression_Trees_in_.NET.React.Data
{
    public class EntitiesDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Product> Products { get; set; }
        
        public DbSet<Category> Categories { get; set; }

        public EntitiesDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }
    }
}