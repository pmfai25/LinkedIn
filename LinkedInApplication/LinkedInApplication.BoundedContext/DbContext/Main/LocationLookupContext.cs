using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using LinkedInApplication.BoundedContext.SqlContext;
using LinkedInApplication.Models.Main;
using LinkedInApplication.Models;
using LinkedInApplication.BoundedContext.Singleton;
using RxWeb.Core.Data;
using RxWeb.Core.Data.Models;
using RxWeb.Core.Data.BoundedContext;

namespace LinkedInApplication.BoundedContext.Main
{
    public class LocationLookupContext : BaseBoundedContext, ILocationLookupContext
    {
        public LocationLookupContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<vCountry> vCountry { get; set; }
		public DbSet<vState> vState { get; set; }
		public DbSet<vCity> vCity { get; set; }
            #endregion DbSets


    }


    public interface ILocationLookupContext : IDbContext
    {
    }
}

