using Microsoft.Extensions.DependencyInjection;
using TechnicalTask.Services.Implementations;
using TechnicalTask.Services.Interfaces;

namespace TechnicalTask.Services
{
    public static class ServicesInjection
    {
        public static IServiceCollection AddServiceLayer(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IPositionService, PositionService>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IServiceService, ServiceService>();

            return services;
        }
    }
}
