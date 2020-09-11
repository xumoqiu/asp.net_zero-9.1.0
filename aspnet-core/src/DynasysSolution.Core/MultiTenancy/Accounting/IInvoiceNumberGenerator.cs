using System.Threading.Tasks;
using Abp.Dependency;

namespace DynasysSolution.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}