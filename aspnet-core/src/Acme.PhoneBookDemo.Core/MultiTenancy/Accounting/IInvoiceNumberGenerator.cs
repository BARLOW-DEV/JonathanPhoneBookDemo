using System.Threading.Tasks;
using Abp.Dependency;

namespace Acme.PhoneBookDemo.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}