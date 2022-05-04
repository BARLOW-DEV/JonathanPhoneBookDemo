using System.Collections.Generic;
using LibraryDemo.Authorization.Users.Importing.Dto;
using LibraryDemo.Dto;

namespace LibraryDemo.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
