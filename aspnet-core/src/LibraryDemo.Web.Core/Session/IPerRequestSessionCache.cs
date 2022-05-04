using System.Threading.Tasks;
using LibraryDemo.Sessions.Dto;

namespace LibraryDemo.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
