using System.Threading.Tasks;
using Abp.Application.Services;

namespace LibraryDemo.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
