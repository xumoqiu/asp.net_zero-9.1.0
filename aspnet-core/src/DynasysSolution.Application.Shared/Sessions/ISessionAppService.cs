using System.Threading.Tasks;
using Abp.Application.Services;
using DynasysSolution.Sessions.Dto;

namespace DynasysSolution.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
