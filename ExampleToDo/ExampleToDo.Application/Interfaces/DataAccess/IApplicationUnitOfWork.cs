using ExampleToDo.Domain.Interfaces;
using ExampleToDo.Domain.Specific;
using System.Threading;
using System.Threading.Tasks;

namespace ExampleToDo.Application.Interfaces.DataAccess
{
    public interface IApplicationUnitOfWork<TDomainUser> where TDomainUser : IDomainUser
    {
        IApplicationRepository<TDomainUser> ApplicationUsers { get; set; }
        IApplicationRepository<CustomTask<TDomainUser>> CustomTasks { get; set; }
        IApplicationRepository<CustomSubtask<TDomainUser>> CustomSubtasks { get; set; }
        IApplicationRepository<CustomTaskList<TDomainUser>> CustomTaskLists { get; set; }
        IApplicationRepository<CustomTaskListGroup<TDomainUser>> CustomTaskListGroups { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
