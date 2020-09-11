using System.Collections.Generic;
using DynasysSolution.Authorization.Permissions.Dto;

namespace DynasysSolution.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}