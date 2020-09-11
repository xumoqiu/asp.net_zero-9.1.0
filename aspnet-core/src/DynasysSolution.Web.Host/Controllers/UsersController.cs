using Abp.AspNetCore.Mvc.Authorization;
using DynasysSolution.Authorization;
using DynasysSolution.Storage;
using Abp.BackgroundJobs;

namespace DynasysSolution.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}