using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using DynasysSolution.Dto;

namespace DynasysSolution.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
