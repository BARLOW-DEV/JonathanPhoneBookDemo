using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using LibraryDemo.MultiTenancy.Accounting.Dto;

namespace LibraryDemo.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
