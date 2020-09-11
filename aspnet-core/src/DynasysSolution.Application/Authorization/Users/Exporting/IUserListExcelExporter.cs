using System.Collections.Generic;
using DynasysSolution.Authorization.Users.Dto;
using DynasysSolution.Dto;

namespace DynasysSolution.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}