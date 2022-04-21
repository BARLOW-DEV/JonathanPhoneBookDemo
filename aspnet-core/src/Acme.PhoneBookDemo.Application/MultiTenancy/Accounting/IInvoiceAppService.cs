using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Acme.PhoneBookDemo.MultiTenancy.Accounting.Dto;

namespace Acme.PhoneBookDemo.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
