using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace DynasysSolution.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
