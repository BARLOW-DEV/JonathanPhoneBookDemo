using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryDemo.Sessions.Dto;

namespace LibraryDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
