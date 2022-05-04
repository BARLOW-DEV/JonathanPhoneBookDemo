using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using LibraryDemo.Dto;

namespace LibraryDemo.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
