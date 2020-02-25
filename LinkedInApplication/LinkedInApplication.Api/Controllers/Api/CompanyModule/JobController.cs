using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace LinkedInApplication.Api.Controllers.CompanyModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class JobController : BaseController<Job,Job,Job>

    {
        public JobController(ICompanyUow uow):base(uow) {}

    }
}