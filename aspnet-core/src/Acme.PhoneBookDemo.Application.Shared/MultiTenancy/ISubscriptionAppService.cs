using System.Threading.Tasks;
using Abp.Application.Services;

namespace Acme.PhoneBookDemo.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
