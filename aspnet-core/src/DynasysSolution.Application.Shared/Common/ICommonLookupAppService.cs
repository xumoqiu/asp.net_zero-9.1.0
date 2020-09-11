using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DynasysSolution.Common.Dto;
using DynasysSolution.Editions.Dto;

namespace DynasysSolution.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}