using System.Threading.Tasks;
using Abp.Application.Services;
using Acme.PhoneBookDemo.Sessions.Dto;

namespace Acme.PhoneBookDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
