using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DynasysSolution.Authorization.Users.Dto;

namespace DynasysSolution.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
