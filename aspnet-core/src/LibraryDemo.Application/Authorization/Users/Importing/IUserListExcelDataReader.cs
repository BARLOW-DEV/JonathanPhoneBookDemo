using System.Collections.Generic;
using LibraryDemo.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace LibraryDemo.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
