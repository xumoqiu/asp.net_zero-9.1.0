using System.Threading.Tasks;
using DynasysSolution.Sessions.Dto;

namespace DynasysSolution.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
