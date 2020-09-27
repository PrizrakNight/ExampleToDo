using ExampleToDo.Application.Interfaces.DataAccess;
using ExampleToDo.Persistence.EFCore.Entities;
using ExampleToDo.Persistence.EFCore.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ExampleToDo.Persistence.EFCore
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceEFCore(this IServiceCollection services, Action<DbContextOptionsBuilder> options)
        {
            services.AddDbContextPool<ApplicationDbContext>(options);
            services.AddTransient<IApplicationUnitOfWork<ApplicationIdentityUser>, DbContextUnitOfWork>();

            return services;
        }
    }
}
