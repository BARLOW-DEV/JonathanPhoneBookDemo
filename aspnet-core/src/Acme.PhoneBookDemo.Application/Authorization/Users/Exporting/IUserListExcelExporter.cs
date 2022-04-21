using System.Collections.Generic;
using Acme.PhoneBookDemo.Authorization.Users.Dto;
using Acme.PhoneBookDemo.Dto;

namespace Acme.PhoneBookDemo.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}