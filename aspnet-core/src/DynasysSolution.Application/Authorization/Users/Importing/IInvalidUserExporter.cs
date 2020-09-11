using System.Collections.Generic;
using DynasysSolution.Authorization.Users.Importing.Dto;
using DynasysSolution.Dto;

namespace DynasysSolution.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
