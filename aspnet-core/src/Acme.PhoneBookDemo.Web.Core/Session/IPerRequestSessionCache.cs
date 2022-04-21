using System.Threading.Tasks;
using Acme.PhoneBookDemo.Sessions.Dto;

namespace Acme.PhoneBookDemo.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
