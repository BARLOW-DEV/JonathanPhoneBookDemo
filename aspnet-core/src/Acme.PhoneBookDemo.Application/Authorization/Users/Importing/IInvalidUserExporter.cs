using System.Collections.Generic;
using Acme.PhoneBookDemo.Authorization.Users.Importing.Dto;
using Acme.PhoneBookDemo.Dto;

namespace Acme.PhoneBookDemo.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
