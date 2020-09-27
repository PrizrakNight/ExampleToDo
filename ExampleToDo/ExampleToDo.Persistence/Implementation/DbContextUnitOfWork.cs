using ExampleToDo.Application.Interfaces.DataAccess;
using ExampleToDo.Domain.Specific;
using ExampleToDo.Persistence.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace ExampleToDo.Persistence.EFCore.Implementation
{
    public class DbContextUnitOfWork : IApplicationUnitOfWork<ApplicationIdentityUser>
    {
        public IApplicationRepository<CustomTask<ApplicationIdentityUser>> CustomTasks { get; set; }
        public IApplicationRepository<CustomSubtask<ApplicationIdentityUser>> CustomSubtasks { get; set; }
        public IApplicationRepository<CustomTaskList<ApplicationIdentityUser>> CustomTaskLists { get; set; }
        public IApplicationRepository<CustomTaskListGroup<ApplicationIdentityUser>> CustomTaskListGroups { get; set; }
        public IApplicationRepository<ApplicationIdentityUser> ApplicationUsers { get; set; }

        private readonly ApplicationDbContext _applicationDbContext;

        public DbContextUnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;

            CustomSubtasks = new DbSetRepository<CustomSubtask<ApplicationIdentityUser>>(_applicationDbContext.Subtasks);
            CustomTasks = new DbSetRepository<CustomTask<ApplicationIdentityUser>>(_applicationDbContext.Tasks, set => set.Include(ct => ct.Assigned));

            ApplicationUsers = new DbSetRepository<ApplicationIdentityUser>(_applicationDbContext.Users, set => set
                                                    .Include(au => au.Groups)
                                                    .Include(au => au.TaskLists));

            CustomTaskListGroups = new DbSetRepository<CustomTaskListGroup<ApplicationIdentityUser>>(_applicationDbContext.ListGroups, set => set
                                                    .Include(lg => lg.CustomTaskLists));

            CustomTaskLists = new DbSetRepository<CustomTaskList<ApplicationIdentityUser>>(_applicationDbContext.TaskLists, set => set
                                                    .Include(tl => tl.Participants)
                                                    .Include(tl => tl.TaskListGroup)
                                                    .Include(tl => tl.Tasks));
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) => _applicationDbContext.SaveChangesAsync(cancellationToken);
    }
}
