#region Namespace
using Microsoft.Extensions.DependencyInjection;
using LinkedInApplication.Infrastructure.Security;
using RxWeb.Core.Data;
using RxWeb.Core.Security;
using RxWeb.Core.Annotations;
using RxWeb.Core;
using LinkedInApplication.UnitOfWork.DbEntityAudit;
using LinkedInApplication.BoundedContext.Main;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Domain.UserModule;
            using LinkedInApplication.UnitOfWork.Lookups;
            using LinkedInApplication.Domain.CompanyModule;
            #endregion Namespace







namespace LinkedInApplication.Api.Bootstrap
{
    public static class ScopedExtension
    {

        public static void AddScopedService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepositoryProvider, RepositoryProvider>();
            serviceCollection.AddScoped<ITokenAuthorizer, TokenAuthorizer>();
            serviceCollection.AddScoped<IModelValidation, ModelValidation>();
            serviceCollection.AddScoped<IAuditLog, AuditLog>();
            serviceCollection.AddScoped<IApplicationTokenProvider, ApplicationTokenProvider>();
            serviceCollection.AddScoped(typeof(IDbContextManager<>), typeof(DbContextManager<>));

            #region ContextService

            serviceCollection.AddScoped<ILoginContext, LoginContext>();
            serviceCollection.AddScoped<ILoginUow, LoginUow>();
            serviceCollection.AddScoped<IMasterContext, MasterContext>();
            serviceCollection.AddScoped<IMasterUow, MasterUow>();
            serviceCollection.AddScoped<IUserContext, UserContext>();
            serviceCollection.AddScoped<IUserUow, UserUow>();
            serviceCollection.AddScoped<ICompanyContext, CompanyContext>();
            serviceCollection.AddScoped<ICompanyUow, CompanyUow>();
            serviceCollection.AddScoped<ILocationUow, LocationUow>();
                        serviceCollection.AddScoped<ILocationLookupContext, LocationLookupContext>();
            serviceCollection.AddScoped<ILocationLookupUow, LocationLookupUow>();
                        serviceCollection.AddScoped<ILocationLookupContext, LocationLookupContext>();
            serviceCollection.AddScoped<ILocationLookupUow, LocationLookupUow>();
            #endregion ContextService












            #region DomainService


            serviceCollection.AddScoped<IUserDomain, UserDomain>();
            
            serviceCollection.AddScoped<ILinkedInUserDomain, LinkedInUserDomain>();
            
            serviceCollection.AddScoped<IUserExperienceDomain, UserExperienceDomain>();
            
            serviceCollection.AddScoped<IDesignationDomain, DesignationDomain>();
            
            serviceCollection.AddScoped<ICompanyDetailDomain, CompanyDetailDomain>();
            
            serviceCollection.AddScoped<ICompanyDetailDomain, CompanyDetailDomain>();
            
            
            serviceCollection.AddScoped<IUserCertificationDomain, UserCertificationDomain>();
            
            serviceCollection.AddScoped<IUserEducationDetailDomain, UserEducationDetailDomain>();
            
            serviceCollection.AddScoped<IUserSkillDomain, UserSkillDomain>();
            
            serviceCollection.AddScoped<IPostDomain, PostDomain>();
            #endregion DomainService











        }
    }
}




