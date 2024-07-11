using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Presistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HR.LeaveManagement.Presistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePeristenceServices(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<LeaveManagementDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("LeaveManagmentConnectionString")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
            services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();

            return services;
        }
    }
}
