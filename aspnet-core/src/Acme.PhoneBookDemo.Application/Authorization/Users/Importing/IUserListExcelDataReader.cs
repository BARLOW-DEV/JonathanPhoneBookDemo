using System.Collections.Generic;
using Acme.PhoneBookDemo.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace Acme.PhoneBookDemo.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
