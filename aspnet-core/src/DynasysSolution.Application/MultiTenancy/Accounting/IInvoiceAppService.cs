using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using DynasysSolution.MultiTenancy.Accounting.Dto;

namespace DynasysSolution.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
