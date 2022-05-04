using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace LibraryDemo.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
