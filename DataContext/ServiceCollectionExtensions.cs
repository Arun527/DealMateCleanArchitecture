using Authorization.Interfaces;
using Authorization.Services.Enforcer;
using Common.PredicateBuilder;
using Core.Domain.Aggregates;
using Core.Domain.Filters;
using Core.Domain.PredicateBuilder;
using Core.Interfaces;
using DataContext.AuthorizationRepository;
using DataContext.CoreRepository;
using DataContext.Db;
using DataContext.ExcelService;
using DataContext.GenericRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataContext.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection InfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped(typeof(IReadRepository<,>), typeof(ReadRepository<,>));
        services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
        services.AddHttpContextAccessor();
        services.AddSignalR();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IDealerRepository, DealerRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<IBranchRepository, BranchRepository>();
        services.AddScoped<IPermissionRepository, PermissionRepository>();
        services.AddScoped<IRolePermissionRepository, RolePermissionRepository>();
        services.AddScoped<IEnforcer, EnforcerService>();
        services.AddScoped<IExcelService, ExcelService>();
        services.AddScoped<IVehicleRepository, VehicleRepository>();
        services.AddControllers(options =>
        {
            options.Filters.Add<HttpResponseExceptionFilter>(); // Add the custom exception filter
        });
        services.AddScoped<IPredicateBuilder<Vehicle, VehicleFilter>, VehicleFilterPredicateBuilder>();

        return services;
    }
}
