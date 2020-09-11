using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DynasysSolution.Authorization.Permissions.Dto;

namespace DynasysSolution.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
