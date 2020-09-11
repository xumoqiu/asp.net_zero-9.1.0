using System.Collections.Generic;
using DynasysSolution.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace DynasysSolution.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
