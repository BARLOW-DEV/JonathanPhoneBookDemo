using System.Collections.Generic;
using LibraryDemo.Authorization.Users.Dto;
using LibraryDemo.Dto;

namespace LibraryDemo.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}