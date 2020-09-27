using ExampleToDo.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace ExampleToDo.Application.Interfaces.DataAccess
{
    public interface IApplicationRepository<TDomainEntity> where TDomainEntity : IDomainEntity
    {
        Task<TDomainEntity[]> Get(Func<TDomainEntity, bool> predicate = default);

        Task<TDomainEntity> FindAsync(int entityId);

        Task<bool> UpdateAsync(TDomainEntity entity);
        Task<bool> InsertAsync(TDomainEntity entity);
        Task<bool> DeleteAsync(TDomainEntity entity);
    }
}
