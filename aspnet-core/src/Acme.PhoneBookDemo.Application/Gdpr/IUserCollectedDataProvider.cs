using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Acme.PhoneBookDemo.Dto;

namespace Acme.PhoneBookDemo.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
