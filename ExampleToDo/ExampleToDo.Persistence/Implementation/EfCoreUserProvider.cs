using ExampleToDo.Application;
using ExampleToDo.Application.Interfaces;
using ExampleToDo.Domain.Interfaces;
using ExampleToDo.Persistence.EFCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ExampleToDo.Persistence.EFCore.Implementation
{
    public class EfCoreUserProvider : IApplicationUserProvider
    {
        public IDomainUser CurrentUser
        {
            get
            {
                if(_currentUser == default)
                {
                    var userIdClaim = _accessor.HttpContext.User.FindFirst(ApplicationUserClaimTypes.UserId);
                    var userId = int.Parse(userIdClaim.Value);

                    _currentUser = _applicationDbContext.Users
                        .Include(u => u.Groups)
                        .Include(u => u.TaskLists)
                        .Single(u => u.Id == userId);
                }

                return _currentUser;
            }
        }

        private ApplicationIdentityUser _currentUser;

        private readonly ApplicationDbContext _applicationDbContext;

        private readonly IHttpContextAccessor _accessor;
    }
}
